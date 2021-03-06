﻿using System;
using System.Runtime.Serialization;

[Serializable]
internal class InvalidMenuTypeException : Exception {
	public InvalidMenuTypeException() {
	}

	public InvalidMenuTypeException(string message)
		: base(message) {
	}

	public InvalidMenuTypeException(string message, Exception innerException)
		: base(message, innerException) {
	}

	protected InvalidMenuTypeException(SerializationInfo info, StreamingContext context)
		: base(info, context) {
	}
}
