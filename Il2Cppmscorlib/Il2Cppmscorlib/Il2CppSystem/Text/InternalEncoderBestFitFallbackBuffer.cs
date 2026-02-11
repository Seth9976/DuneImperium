using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000201 RID: 513
	public sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x060020F5 RID: 8437 RVA: 0x000BC144 File Offset: 0x000BA344
		// Note: this type is marked as 'beforefieldinit'.
		static InternalEncoderBestFitFallbackBuffer()
		{
			Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "InternalEncoderBestFitFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr);
			InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__cBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, "_cBestFit");
			InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__oFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, "_oFallback");
			InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__iCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, "_iCount");
			InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__iSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, "_iSize");
			InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, "s_InternalSyncObject");
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100668877);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_InternalEncoderBestFitFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100668878);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100668879);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100668880);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100668881);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100668882);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100668883);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100668884);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_TryBestFit_Private_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100668885);
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x000BC28C File Offset: 0x000BA48C
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362663, XrefRangeEnd = 1362672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000BC2C0 File Offset: 0x000BA4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1362688, RefRangeEnd = 1362689, XrefRangeStart = 1362672, XrefRangeEnd = 1362688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_InternalEncoderBestFitFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x000BC30C File Offset: 0x000BA50C
		[CallerCount(0)]
		public unsafe override bool Fallback(char charUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknown;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000BC364 File Offset: 0x000BA564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362689, XrefRangeEnd = 1362696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknownHigh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000BC3CC File Offset: 0x000BA5CC
		[CallerCount(0)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000BC408 File Offset: 0x000BA608
		[CallerCount(0)]
		public unsafe override bool MovePrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x000BC444 File Offset: 0x000BA644
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x000BC480 File Offset: 0x000BA680
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x000BC4B4 File Offset: 0x000BA6B4
		[CallerCount(0)]
		public unsafe char TryBestFit(char cUnknown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cUnknown;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_TryBestFit_Private_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x0000AA93 File Offset: 0x00008C93
		public InternalEncoderBestFitFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x000BC500 File Offset: 0x000BA700
		// (set) Token: 0x06002101 RID: 8449 RVA: 0x0000AA9C File Offset: 0x00008C9C
		public unsafe char _cBestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__cBestFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__cBestFit)) = value;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x000BC528 File Offset: 0x000BA728
		// (set) Token: 0x06002103 RID: 8451 RVA: 0x0000AAB7 File Offset: 0x00008CB7
		public unsafe InternalEncoderBestFitFallback _oFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__oFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalEncoderBestFitFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__oFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x000BC558 File Offset: 0x000BA758
		// (set) Token: 0x06002105 RID: 8453 RVA: 0x0000AAD6 File Offset: 0x00008CD6
		public unsafe int _iCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__iCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__iCount)) = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x000BC580 File Offset: 0x000BA780
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x0000AAF1 File Offset: 0x00008CF1
		public unsafe int _iSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__iSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr__iSize)) = value;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x000BC5A8 File Offset: 0x000BA7A8
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x0000AB0C File Offset: 0x00008D0C
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeFieldInfoPtr__cBestFit;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeFieldInfoPtr__oFallback;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeFieldInfoPtr__iCount;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeFieldInfoPtr__iSize;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InternalEncoderBestFitFallback_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x04001D47 RID: 7495
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04001D48 RID: 7496
		private static readonly IntPtr NativeMethodInfoPtr_TryBestFit_Private_Char_Char_0;
	}
}
