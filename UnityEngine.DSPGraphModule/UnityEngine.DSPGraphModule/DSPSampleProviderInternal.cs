using System;
using Il2CppInterop.Runtime;

namespace Unity.Audio
{
	// Token: 0x02000007 RID: 7
	public struct DSPSampleProviderInternal
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000020EF File Offset: 0x000002EF
		public unsafe static int Internal_ReadUInt8FromSampleProvider(void* provider, int format, void* buffer, int length)
		{
			return DSPSampleProviderInternal.Internal_ReadUInt8FromSampleProviderDelegateField(provider, format, buffer, length);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020FF File Offset: 0x000002FF
		public unsafe static int Internal_ReadSInt16FromSampleProvider(void* provider, int format, void* buffer, int length)
		{
			return DSPSampleProviderInternal.Internal_ReadSInt16FromSampleProviderDelegateField(provider, format, buffer, length);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000210F File Offset: 0x0000030F
		public unsafe static int Internal_ReadFloatFromSampleProvider(void* provider, void* buffer, int length)
		{
			return DSPSampleProviderInternal.Internal_ReadFloatFromSampleProviderDelegateField(provider, buffer, length);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000211E File Offset: 0x0000031E
		public unsafe static ushort Internal_GetChannelCount(void* provider)
		{
			return DSPSampleProviderInternal.Internal_GetChannelCountDelegateField(provider);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000212B File Offset: 0x0000032B
		public unsafe static uint Internal_GetSampleRate(void* provider)
		{
			return DSPSampleProviderInternal.Internal_GetSampleRateDelegateField(provider);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002138 File Offset: 0x00000338
		public unsafe static int Internal_ReadUInt8FromSampleProviderById(uint providerId, int format, void* buffer, int length)
		{
			return DSPSampleProviderInternal.Internal_ReadUInt8FromSampleProviderByIdDelegateField(providerId, format, buffer, length);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002148 File Offset: 0x00000348
		public unsafe static int Internal_ReadSInt16FromSampleProviderById(uint providerId, int format, void* buffer, int length)
		{
			return DSPSampleProviderInternal.Internal_ReadSInt16FromSampleProviderByIdDelegateField(providerId, format, buffer, length);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002158 File Offset: 0x00000358
		public unsafe static int Internal_ReadFloatFromSampleProviderById(uint providerId, void* buffer, int length)
		{
			return DSPSampleProviderInternal.Internal_ReadFloatFromSampleProviderByIdDelegateField(providerId, buffer, length);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002167 File Offset: 0x00000367
		public static ushort Internal_GetChannelCountById(uint providerId)
		{
			return DSPSampleProviderInternal.Internal_GetChannelCountByIdDelegateField(providerId);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002174 File Offset: 0x00000374
		public static uint Internal_GetSampleRateById(uint providerId)
		{
			return DSPSampleProviderInternal.Internal_GetSampleRateByIdDelegateField(providerId);
		}

		// Token: 0x04000008 RID: 8
		private static readonly DSPSampleProviderInternal.Internal_ReadUInt8FromSampleProviderDelegate Internal_ReadUInt8FromSampleProviderDelegateField = IL2CPP.ResolveICall<DSPSampleProviderInternal.Internal_ReadUInt8FromSampleProviderDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadUInt8FromSampleProvider");

		// Token: 0x04000009 RID: 9
		private static readonly DSPSampleProviderInternal.Internal_ReadSInt16FromSampleProviderDelegate Internal_ReadSInt16FromSampleProviderDelegateField = IL2CPP.ResolveICall<DSPSampleProviderInternal.Internal_ReadSInt16FromSampleProviderDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadSInt16FromSampleProvider");

		// Token: 0x0400000A RID: 10
		private static readonly DSPSampleProviderInternal.Internal_ReadFloatFromSampleProviderDelegate Internal_ReadFloatFromSampleProviderDelegateField = IL2CPP.ResolveICall<DSPSampleProviderInternal.Internal_ReadFloatFromSampleProviderDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadFloatFromSampleProvider");

		// Token: 0x0400000B RID: 11
		private static readonly DSPSampleProviderInternal.Internal_GetChannelCountDelegate Internal_GetChannelCountDelegateField = IL2CPP.ResolveICall<DSPSampleProviderInternal.Internal_GetChannelCountDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_GetChannelCount");

		// Token: 0x0400000C RID: 12
		private static readonly DSPSampleProviderInternal.Internal_GetSampleRateDelegate Internal_GetSampleRateDelegateField = IL2CPP.ResolveICall<DSPSampleProviderInternal.Internal_GetSampleRateDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_GetSampleRate");

		// Token: 0x0400000D RID: 13
		private static readonly DSPSampleProviderInternal.Internal_ReadUInt8FromSampleProviderByIdDelegate Internal_ReadUInt8FromSampleProviderByIdDelegateField = IL2CPP.ResolveICall<DSPSampleProviderInternal.Internal_ReadUInt8FromSampleProviderByIdDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadUInt8FromSampleProviderById");

		// Token: 0x0400000E RID: 14
		private static readonly DSPSampleProviderInternal.Internal_ReadSInt16FromSampleProviderByIdDelegate Internal_ReadSInt16FromSampleProviderByIdDelegateField = IL2CPP.ResolveICall<DSPSampleProviderInternal.Internal_ReadSInt16FromSampleProviderByIdDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadSInt16FromSampleProviderById");

		// Token: 0x0400000F RID: 15
		private static readonly DSPSampleProviderInternal.Internal_ReadFloatFromSampleProviderByIdDelegate Internal_ReadFloatFromSampleProviderByIdDelegateField = IL2CPP.ResolveICall<DSPSampleProviderInternal.Internal_ReadFloatFromSampleProviderByIdDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_ReadFloatFromSampleProviderById");

		// Token: 0x04000010 RID: 16
		private static readonly DSPSampleProviderInternal.Internal_GetChannelCountByIdDelegate Internal_GetChannelCountByIdDelegateField = IL2CPP.ResolveICall<DSPSampleProviderInternal.Internal_GetChannelCountByIdDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_GetChannelCountById");

		// Token: 0x04000011 RID: 17
		private static readonly DSPSampleProviderInternal.Internal_GetSampleRateByIdDelegate Internal_GetSampleRateByIdDelegateField = IL2CPP.ResolveICall<DSPSampleProviderInternal.Internal_GetSampleRateByIdDelegate>("Unity.Audio.DSPSampleProviderInternal::Internal_GetSampleRateById");

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000028 RID: 40
		private delegate int Internal_ReadUInt8FromSampleProviderDelegate(IntPtr provider, int format, IntPtr buffer, int length);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600002A RID: 42
		private delegate int Internal_ReadSInt16FromSampleProviderDelegate(IntPtr provider, int format, IntPtr buffer, int length);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600002C RID: 44
		private delegate int Internal_ReadFloatFromSampleProviderDelegate(IntPtr provider, IntPtr buffer, int length);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600002E RID: 46
		private delegate ushort Internal_GetChannelCountDelegate(IntPtr provider);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000030 RID: 48
		private delegate uint Internal_GetSampleRateDelegate(IntPtr provider);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000032 RID: 50
		private delegate int Internal_ReadUInt8FromSampleProviderByIdDelegate(uint providerId, int format, IntPtr buffer, int length);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000034 RID: 52
		private delegate int Internal_ReadSInt16FromSampleProviderByIdDelegate(uint providerId, int format, IntPtr buffer, int length);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000036 RID: 54
		private delegate int Internal_ReadFloatFromSampleProviderByIdDelegate(uint providerId, IntPtr buffer, int length);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000038 RID: 56
		private delegate ushort Internal_GetChannelCountByIdDelegate(uint providerId);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600003A RID: 58
		private delegate uint Internal_GetSampleRateByIdDelegate(uint providerId);
	}
}
