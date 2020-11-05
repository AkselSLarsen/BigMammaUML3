using System;
using System.Runtime.Serialization;

[Serializable]
internal class MenuItemNumberExistsException : Exception {
	public MenuItemNumberExistsException() {
	}

	public MenuItemNumberExistsException(string message)
		: base(message) {
	}

	public MenuItemNumberExistsException(string message, Exception innerException)
		: base(message, innerException) {
	}

	protected MenuItemNumberExistsException(SerializationInfo info, StreamingContext context)
		: base(info, context) {
	}
}