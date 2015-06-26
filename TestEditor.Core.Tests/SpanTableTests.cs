using NUnit.Framework;
using TextEditor.Core;

namespace TestEditor.Core.Tests
{
	[TestFixture]
	public class SpanTableTests
	{
		[Test(Description = "Functional tests.")]
		public void Test01FunctionalTest()
		{
			var st = new SpanTable();

			var span = new Span(0, 0, 10);
			st.Insert(0, 10);
			Assert.AreEqual(span, st.Head);

			//	0 1 2 3 4 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9          
			//	0, 5/0, 10/5, 5
			st.Insert(5, 10);
			var temp = st.Head;
			span = new Span(0, 0, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(1, 0, 10);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(0, 5, 5);
			Assert.AreEqual(span, temp);
		}

		[Test(Description = "Functional tests - insert at begining of span.")]
		public void Test02FunctionalInsertTest()
		{
			//	0 1 2 3 4 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J a b 5 6 7 8 9
			//	0, 5/0, 10/10, 2/5, 5
			var st = new SpanTable();
			st.Insert(0, 10);
			st.Insert(5, 10);
			st.Insert(15, 2);
			var temp = st.Head;
			var span = new Span(0, 0, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(1, 0, 10);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(1, 10, 2);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(0, 5, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNull(temp.Next);
		}

		[Test(Description = "Functional tests - insert at head of table.")]
		public void Test03FunctionalInsertHead()
		{
			//	0 1 2 3 4 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J a b 5 6 7 8 9
			//	a b c 0 1 2 3 4 A B C D E F G H I J a b 5 6 7 8 9
			//	12, 3/0, 5/0, 10/10, 2/5, 5
			var st = new SpanTable();
			st.Insert(0, 10);
			st.Insert(5, 10);
			st.Insert(15, 2);
			st.Insert(0, 3);
			var temp = st.Head;
			var span = new Span(1, 12, 3);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(0, 0, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(1, 0, 10);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(1, 10, 2);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(0, 5, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNull(temp.Next);
		}

		[Test(Description = "Functional tests - insert at tail of table.")]
		public void Test04FunctionalInsertTest()
		{
			//	0 1 2 3 4 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9 a b 
			//	0, 5/0, 10/5, 5/10, 2
			var st = new SpanTable();
			st.Insert(0, 10);
			st.Insert(5, 10);
			st.Insert(20, 2);
			var temp = st.Tail;
			var span = new Span(1, 10, 2);

			Assert.AreEqual(span, temp);
			Assert.IsNull(temp.Next);
		}

		[Test(Description = "Functional tests - delete")]
		public void Test05FunctionalDelete()
		{
			//	0 1 2 3 4 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9 a b 
			//	0 1 2 3 J 5 6 7 8 9 a b 
			//	0, 4/9, 1/5, 5/10, 2
			var st = new SpanTable();
			st.Insert(0, 10);
			st.Insert(5, 10);
			st.Insert(20, 2);
			st.Delete(4, 10);
			var temp = st.Head;
			var span = new Span(0, 0, 4);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(1, 9, 1);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(0, 5, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(1, 10, 2);
			Assert.AreEqual(span, temp);
			Assert.IsNull(temp.Next);
		}

		[Test(Description = "Functional tests - delete single span head.")]
		public void Test06FunctionalDeleteSingleSpanHead()
		{
			//	0 1 2 3 4 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9 a b 
			//	0 1 2 3 4 5 6 7 8 9 a b 
			//	0, 5/5, 5/10, 2
			var st = new SpanTable();
			st.Insert(0, 10);
			st.Insert(5, 10);
			st.Insert(20, 2);
			var temp = st.Head;
			var span = new Span(0, 0, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			Assert.IsNotNull(temp.Previous);
			Assert.IsNotNull(temp.Next);
			span = new Span(1, 0, 10);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			st.Delete(5, 10);

			temp = st.Head;
			span = new Span(0, 0, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(0, 5, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(1, 10, 2);
			Assert.AreEqual(span, temp);
			Assert.IsNull(temp.Next);
		}

		[Test(Description = "Functional tests - delete single span tail.")]
		public void Test07FunctionalDeleteSingleSpanTail()
		{
			//	0 1 2 3 4 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9 a b
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9 
			//	0, 5/0, 10/5, 5
			var st = new SpanTable();
			st.Insert(0, 10);
			st.Insert(5, 10);
			st.Insert(20, 2);
			var temp = st.Head;
			var span = new Span(0, 0, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			Assert.IsNotNull(temp.Previous);
			Assert.IsNotNull(temp.Next);
			span = new Span(1, 0, 10);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			st.Delete(20, 2);

			temp = st.Head;
			span = new Span(0, 0, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(1, 0, 10);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(0, 5, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNull(temp.Next);
		}

		[Test(Description = "Functional tests - delete multiple span extra length.")]
		public void Test08FunctionalDeleteMultiSpanExtraLength()
		{
			//	0 1 2 3 4 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9
			//	0 1 2 3 4 A B C D E F G H I J 5 6 7 8 9 a b
			//	0 1 2 3 4 A B C D E F G H I J 5 
			//	0, 5/0, 10/5, 1
			var st = new SpanTable();
			st.Insert(0, 10);
			st.Insert(5, 10);
			st.Insert(20, 2);
			var temp = st.Head;
			var span = new Span(0, 0, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			Assert.IsNotNull(temp.Previous);
			Assert.IsNotNull(temp.Next);
			span = new Span(1, 0, 10);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			st.Delete(16, 1000);

			temp = st.Head;
			span = new Span(0, 0, 5);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(1, 0, 10);
			Assert.AreEqual(span, temp);
			Assert.IsNotNull(temp.Next);

			temp = temp.Next;
			span = new Span(0, 5, 1);
			Assert.AreEqual(span, temp);
			Assert.IsNull(temp.Next);
		}
	}
}
