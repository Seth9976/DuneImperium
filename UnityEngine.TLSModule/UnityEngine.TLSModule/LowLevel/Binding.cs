using System;

namespace Unity.TLS.LowLevel
{
	// Token: 0x02000003 RID: 3
	public static class Binding
	{
		// Token: 0x04000001 RID: 1
		public const int UNITYTLS_SUCCESS = 0;

		// Token: 0x04000002 RID: 2
		public const int UNITYTLS_INVALID_ARGUMENT = 1;

		// Token: 0x04000003 RID: 3
		public const int UNITYTLS_INVALID_FORMAT = 2;

		// Token: 0x04000004 RID: 4
		public const int UNITYTLS_INVALID_PASSWORD = 3;

		// Token: 0x04000005 RID: 5
		public const int UNITYTLS_INVALID_STATE = 4;

		// Token: 0x04000006 RID: 6
		public const int UNITYTLS_BUFFER_OVERFLOW = 5;

		// Token: 0x04000007 RID: 7
		public const int UNITYTLS_OUT_OF_MEMORY = 6;

		// Token: 0x04000008 RID: 8
		public const int UNITYTLS_INTERNAL_ERROR = 7;

		// Token: 0x04000009 RID: 9
		public const int UNITYTLS_NOT_SUPPORTED = 8;

		// Token: 0x0400000A RID: 10
		public const int UNITYTLS_ENTROPY_SOURCE_FAILED = 9;

		// Token: 0x0400000B RID: 11
		public const int UNITYTLS_STREAM_CLOSED = 10;

		// Token: 0x0400000C RID: 12
		public const int UNITYTLS_DER_PARSE_ERROR = 11;

		// Token: 0x0400000D RID: 13
		public const int UNITYTLS_KEY_PARSE_ERROR = 12;

		// Token: 0x0400000E RID: 14
		public const int UNITYTLS_SSL_ERROR = 13;

		// Token: 0x0400000F RID: 15
		public const int UNITYTLS_USER_CUSTOM_ERROR_START = 1048576;

		// Token: 0x04000010 RID: 16
		public const int UNITYTLS_USER_WOULD_BLOCK = 1048577;

		// Token: 0x04000011 RID: 17
		public const int UNITYTLS_USER_WOULD_BLOCK_READ = 1048578;

		// Token: 0x04000012 RID: 18
		public const int UNITYTLS_USER_WOULD_BLOCK_WRITE = 1048579;

		// Token: 0x04000013 RID: 19
		public const int UNITYTLS_USER_READ_FAILED = 1048580;

		// Token: 0x04000014 RID: 20
		public const int UNITYTLS_USER_WRITE_FAILED = 1048581;

		// Token: 0x04000015 RID: 21
		public const int UNITYTLS_USER_UNKNOWN_ERROR = 1048582;

		// Token: 0x04000016 RID: 22
		public const int UNITYTLS_SSL_NEEDS_VERIFY = 1048583;

		// Token: 0x04000017 RID: 23
		public const int UNITYTLS_HANDSHAKE_STEP = 1048584;

		// Token: 0x04000018 RID: 24
		public const int UNITYTLS_USER_CUSTOM_ERROR_END = 2097152;

		// Token: 0x04000019 RID: 25
		public const int UNITYTLS_LOGLEVEL_MIN = 0;

		// Token: 0x0400001A RID: 26
		public const int UNITYTLS_LOGLEVEL_FATAL = 0;

		// Token: 0x0400001B RID: 27
		public const int UNITYTLS_LOGLEVEL_ERROR = 1;

		// Token: 0x0400001C RID: 28
		public const int UNITYTLS_LOGLEVEL_WARN = 2;

		// Token: 0x0400001D RID: 29
		public const int UNITYTLS_LOGLEVEL_INFO = 3;

		// Token: 0x0400001E RID: 30
		public const int UNITYTLS_LOGLEVEL_DEBUG = 4;

		// Token: 0x0400001F RID: 31
		public const int UNITYTLS_LOGLEVEL_TRACE = 5;

		// Token: 0x04000020 RID: 32
		public const int UNITYTLS_LOGLEVEL_MAX = 5;

		// Token: 0x04000021 RID: 33
		public const int UNITYTLS_SSL_HANDSHAKE_HELLO_REQUEST = 0;

		// Token: 0x04000022 RID: 34
		public const int UNITYTLS_SSL_HANDSHAKE_CLIENT_HELLO = 1;

		// Token: 0x04000023 RID: 35
		public const int UNITYTLS_SSL_HANDSHAKE_SERVER_HELLO = 2;

		// Token: 0x04000024 RID: 36
		public const int UNITYTLS_SSL_HANDSHAKE_SERVER_CERTIFICATE = 3;

		// Token: 0x04000025 RID: 37
		public const int UNITYTLS_SSL_HANDSHAKE_SERVER_KEY_EXCHANGE = 4;

		// Token: 0x04000026 RID: 38
		public const int UNITYTLS_SSL_HANDSHAKE_CERTIFICATE_REQUEST = 5;

		// Token: 0x04000027 RID: 39
		public const int UNITYTLS_SSL_HANDSHAKE_SERVER_HELLO_DONE = 6;

		// Token: 0x04000028 RID: 40
		public const int UNITYTLS_SSL_HANDSHAKE_CLIENT_CERTIFICATE = 7;

		// Token: 0x04000029 RID: 41
		public const int UNITYTLS_SSL_HANDSHAKE_CLIENT_KEY_EXCHANGE = 8;

		// Token: 0x0400002A RID: 42
		public const int UNITYTLS_SSL_HANDSHAKE_CERTIFICATE_VERIFY = 9;

		// Token: 0x0400002B RID: 43
		public const int UNITYTLS_SSL_HANDSHAKE_CLIENT_CHANGE_CIPHER_SPEC = 10;

		// Token: 0x0400002C RID: 44
		public const int UNITYTLS_SSL_HANDSHAKE_CLIENT_FINISHED = 11;

		// Token: 0x0400002D RID: 45
		public const int UNITYTLS_SSL_HANDSHAKE_SERVER_CHANGE_CIPHER_SPEC = 12;

		// Token: 0x0400002E RID: 46
		public const int UNITYTLS_SSL_HANDSHAKE_SERVER_FINISHED = 13;

		// Token: 0x0400002F RID: 47
		public const int UNITYTLS_SSL_HANDSHAKE_FLUSH_BUFFERS = 14;

		// Token: 0x04000030 RID: 48
		public const int UNITYTLS_SSL_HANDSHAKE_WRAPUP = 15;

		// Token: 0x04000031 RID: 49
		public const int UNITYTLS_SSL_HANDSHAKE_OVER = 27;

		// Token: 0x04000032 RID: 50
		public const int UNITYTLS_SSL_HANDSHAKE_SERVER_NEW_SESSION_TICKET = 16;

		// Token: 0x04000033 RID: 51
		public const int UNITYTLS_SSL_HANDSHAKE_HELLO_VERIFY_REQUIRED = 17;

		// Token: 0x04000034 RID: 52
		public const int UNITYTLS_SSL_HANDSHAKE_COUNT = 28;

		// Token: 0x04000035 RID: 53
		public const int UNITYTLS_SSL_HANDSHAKE_BEGIN = 0;

		// Token: 0x04000036 RID: 54
		public const int UNITYTLS_SSL_HANDSHAKE_DONE = 27;

		// Token: 0x04000037 RID: 55
		public const int UNITYTLS_SSL_HANDSHAKE_HANDSHAKE_FLUSH_BUFFERS = 14;

		// Token: 0x04000038 RID: 56
		public const int UNITYTLS_SSL_HANDSHAKE_HANDSHAKE_WRAPUP = 15;

		// Token: 0x04000039 RID: 57
		public const int UNITYTLS_SSL_HANDSHAKE_HANDSHAKE_OVER = 27;

		// Token: 0x0400003A RID: 58
		public const int UnityTLSClientAuth_None = 0;

		// Token: 0x0400003B RID: 59
		public const int UnityTLSClientAuth_Optional = 1;

		// Token: 0x0400003C RID: 60
		public const int UnityTLSClientAuth_Required = 2;

		// Token: 0x0400003D RID: 61
		public const int UnityTLSRole_None = 0;

		// Token: 0x0400003E RID: 62
		public const int UnityTLSRole_Server = 1;

		// Token: 0x0400003F RID: 63
		public const int UnityTLSRole_Client = 2;

		// Token: 0x04000040 RID: 64
		public const int UnityTLSTransportProtocol_Stream = 0;

		// Token: 0x04000041 RID: 65
		public const int UnityTLSTransportProtocol_Datagram = 1;

		// Token: 0x04000042 RID: 66
		public const int UnityTLSClientState_None = 0;

		// Token: 0x04000043 RID: 67
		public const int UnityTLSClientState_Init = 1;

		// Token: 0x04000044 RID: 68
		public const int UnityTLSClientState_Handshake = 2;

		// Token: 0x04000045 RID: 69
		public const int UnityTLSClientState_Messaging = 3;

		// Token: 0x04000046 RID: 70
		public const int UnityTLSClientState_Fail = 64;
	}
}
