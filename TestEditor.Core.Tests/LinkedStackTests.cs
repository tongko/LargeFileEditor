using NUnit.Framework;
using TextEditor.Core;

namespace TestEditor.Core.Tests
{
	[TestFixture]
	class LinkedStackTests
	{
		[Test(Description = "Functional Tests push & pop.")]
		public void Test01StackPushPop()
		{
			var s = new LinkedStack<int>();
			s.Push(3);
			s.Push(1);
			s.Push(8);
			s.Push(5);

			Assert.AreEqual(4, s.Count);
			Assert.AreEqual(5, s.Pop());
			Assert.AreEqual(8, s.Pop());
			Assert.AreEqual(1, s.Pop());
			Assert.AreEqual(3, s.Pop());
			Assert.AreEqual(0, s.Count);
			Assert.AreEqual(0, s.Pop());
		}

		[Test(Description = "Functional tests peek.")]
		public void Test02StackPeek()
		{
			var s = new LinkedStack<int>();
			s.Push(3);
			s.Push(1);
			s.Push(8);
			s.Push(5);

			Assert.AreEqual(5, s.Peek());
			s.Pop();
			Assert.AreEqual(8, s.Peek());
			s.Pop();
			Assert.AreEqual(1, s.Peek());
		}
	}
}
