
namespace TextEditor.Core
{
	public class Span
	{
		public Span(int buffer, long offset, long length)
		{
			Buffer = buffer;
			Offset = offset;
			Length = length;

			Previous = Next = null;
		}

		public int Buffer { get; set; }

		public long Offset { get; set; }
		public long Length { get; set; }

		public Span Previous { get; set; }
		public Span Next { get; set; }

		public override string ToString()
		{
			const string format = "TextEditor.Core.Span - Buffer {0}, Offset {1}, Length {2}, Previous {3}, Next {4}";
			var args = new object[5];
			args[0] = Buffer;
			args[1] = Offset;
			args[2] = Length;
			args[3] = Previous == null ? "is null" : "not null";
			args[4] = Next == null ? "is null" : "not null";

			return string.Format(format, args);
		}

		public static bool operator ==(Span lhs, Span rhs)
		{
			if (ReferenceEquals(lhs, rhs)) return true;
			if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) return false;

			return lhs.Buffer == rhs.Buffer && lhs.Offset == rhs.Offset && lhs.Length == rhs.Length;
		}

		public static bool operator !=(Span lhs, Span rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;

			var s = obj as Span;
			return s != null && Equals(s);
		}

		protected bool Equals(Span other)
		{
			return Buffer == other.Buffer && Offset == other.Offset && Length == other.Length;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Buffer;
				hashCode = (hashCode * 397) ^ Offset.GetHashCode();
				hashCode = (hashCode * 397) ^ Length.GetHashCode();
				return hashCode;
			}
		}
	}
}