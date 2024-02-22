

using System;

namespace unmdosx {

	/// <summary>
	/// Protocol.
	/// </summary>
	public enum Protocol
	{
		/// <summary>
		/// No (invalid) protocol.
		/// </summary>
		None = 0,

		/// <summary>
		/// Transmission Control Protocol.
		/// </summary>
		TCP = 1,

		/// <summary>
		/// User Datagram Protocol.
		/// </summary>
		UDP = 2,

		/// <summary>
		/// HyperText Transfer Protocol.
		/// </summary>
		HTTP = 3,

		/// <summary>
		/// XXX: Must be documented.
		/// </summary>
		slowunmdosx = 4,

		/// <summary>
		/// XXX: Must be documented.
		/// </summary>
		ReCoil = 5,

		///<summary>
		/// ICMP Protocol method
		/// </summary>
		ICMP = 6,
	}
}
