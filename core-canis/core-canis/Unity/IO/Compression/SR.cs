using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x0200007D RID: 125
	public class SR : Object
	{
		// Token: 0x06000959 RID: 2393 RVA: 0x00037BD8 File Offset: 0x00035DD8
		// Note: this type is marked as 'beforefieldinit'.
		static SR()
		{
			Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "SR");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr);
			Unity.IO.Compression.SR.NativeFieldInfoPtr_ArgumentOutOfRange_Enum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "ArgumentOutOfRange_Enum");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_CorruptedGZipHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "CorruptedGZipHeader");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_CannotReadFromDeflateStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "CannotReadFromDeflateStream");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_CannotWriteToDeflateStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "CannotWriteToDeflateStream");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_GenericInvalidData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "GenericInvalidData");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidCRC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "InvalidCRC");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidStreamSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "InvalidStreamSize");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidHuffmanData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "InvalidHuffmanData");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidBeginCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "InvalidBeginCall");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidEndCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "InvalidEndCall");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidBlockLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "InvalidBlockLength");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidArgumentOffsetCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "InvalidArgumentOffsetCount");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_NotSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "NotSupported");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_NotWriteableStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "NotWriteableStream");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_NotReadableStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "NotReadableStream");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_ObjectDisposed_StreamClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "ObjectDisposed_StreamClosed");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_UnknownState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "UnknownState");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_UnknownCompressionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "UnknownCompressionMode");
			Unity.IO.Compression.SR.NativeFieldInfoPtr_UnknownBlockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, "UnknownBlockType");
			Unity.IO.Compression.SR.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, 100664605);
			Unity.IO.Compression.SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr, 100664606);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00037DAC File Offset: 0x00035FAC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SR()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity.IO.Compression.SR>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unity.IO.Compression.SR.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00037DE8 File Offset: 0x00035FE8
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unity.IO.Compression.SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0000539F File Offset: 0x0000359F
		public SR(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00037E24 File Offset: 0x00036024
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x000053A8 File Offset: 0x000035A8
		public unsafe static string ArgumentOutOfRange_Enum
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_ArgumentOutOfRange_Enum, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_ArgumentOutOfRange_Enum, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00037E44 File Offset: 0x00036044
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x000053BA File Offset: 0x000035BA
		public unsafe static string CorruptedGZipHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_CorruptedGZipHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_CorruptedGZipHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00037E64 File Offset: 0x00036064
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x000053CC File Offset: 0x000035CC
		public unsafe static string CannotReadFromDeflateStream
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_CannotReadFromDeflateStream, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_CannotReadFromDeflateStream, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00037E84 File Offset: 0x00036084
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x000053DE File Offset: 0x000035DE
		public unsafe static string CannotWriteToDeflateStream
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_CannotWriteToDeflateStream, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_CannotWriteToDeflateStream, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00037EA4 File Offset: 0x000360A4
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x000053F0 File Offset: 0x000035F0
		public unsafe static string GenericInvalidData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_GenericInvalidData, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_GenericInvalidData, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00037EC4 File Offset: 0x000360C4
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00005402 File Offset: 0x00003602
		public unsafe static string InvalidCRC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidCRC, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidCRC, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00037EE4 File Offset: 0x000360E4
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00005414 File Offset: 0x00003614
		public unsafe static string InvalidStreamSize
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidStreamSize, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidStreamSize, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x00037F04 File Offset: 0x00036104
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x00005426 File Offset: 0x00003626
		public unsafe static string InvalidHuffmanData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidHuffmanData, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidHuffmanData, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00037F24 File Offset: 0x00036124
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00005438 File Offset: 0x00003638
		public unsafe static string InvalidBeginCall
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidBeginCall, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidBeginCall, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00037F44 File Offset: 0x00036144
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x0000544A File Offset: 0x0000364A
		public unsafe static string InvalidEndCall
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidEndCall, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidEndCall, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00037F64 File Offset: 0x00036164
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x0000545C File Offset: 0x0000365C
		public unsafe static string InvalidBlockLength
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidBlockLength, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidBlockLength, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x00037F84 File Offset: 0x00036184
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x0000546E File Offset: 0x0000366E
		public unsafe static string InvalidArgumentOffsetCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidArgumentOffsetCount, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_InvalidArgumentOffsetCount, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00037FA4 File Offset: 0x000361A4
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00005480 File Offset: 0x00003680
		public unsafe static string NotSupported
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_NotSupported, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_NotSupported, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00037FC4 File Offset: 0x000361C4
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00005492 File Offset: 0x00003692
		public unsafe static string NotWriteableStream
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_NotWriteableStream, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_NotWriteableStream, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00037FE4 File Offset: 0x000361E4
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x000054A4 File Offset: 0x000036A4
		public unsafe static string NotReadableStream
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_NotReadableStream, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_NotReadableStream, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00038004 File Offset: 0x00036204
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x000054B6 File Offset: 0x000036B6
		public unsafe static string ObjectDisposed_StreamClosed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_ObjectDisposed_StreamClosed, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_ObjectDisposed_StreamClosed, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00038024 File Offset: 0x00036224
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x000054C8 File Offset: 0x000036C8
		public unsafe static string UnknownState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_UnknownState, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_UnknownState, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x00038044 File Offset: 0x00036244
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x000054DA File Offset: 0x000036DA
		public unsafe static string UnknownCompressionMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_UnknownCompressionMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_UnknownCompressionMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00038064 File Offset: 0x00036264
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x000054EC File Offset: 0x000036EC
		public unsafe static string UnknownBlockType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_UnknownBlockType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Unity.IO.Compression.SR.NativeFieldInfoPtr_UnknownBlockType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr_ArgumentOutOfRange_Enum;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr_CorruptedGZipHeader;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr_CannotReadFromDeflateStream;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeFieldInfoPtr_CannotWriteToDeflateStream;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr_GenericInvalidData;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr_InvalidCRC;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeFieldInfoPtr_InvalidStreamSize;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeFieldInfoPtr_InvalidHuffmanData;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeFieldInfoPtr_InvalidBeginCall;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeFieldInfoPtr_InvalidEndCall;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeFieldInfoPtr_InvalidBlockLength;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeFieldInfoPtr_InvalidArgumentOffsetCount;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeFieldInfoPtr_NotSupported;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeFieldInfoPtr_NotWriteableStream;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr_NotReadableStream;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeFieldInfoPtr_ObjectDisposed_StreamClosed;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeFieldInfoPtr_UnknownState;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeFieldInfoPtr_UnknownCompressionMode;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr_UnknownBlockType;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Internal_Static_String_String_0;
	}
}
