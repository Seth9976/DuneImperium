using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x020001F6 RID: 502
	public sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x06002061 RID: 8289 RVA: 0x000B9890 File Offset: 0x000B7A90
		// Note: this type is marked as 'beforefieldinit'.
		static InternalDecoderBestFitFallbackBuffer()
		{
			Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "InternalDecoderBestFitFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr);
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__cBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "_cBestFit");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__iCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "_iCount");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__iSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "_iSize");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__oFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "_oFallback");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "s_InternalSyncObject");
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100668797);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_InternalDecoderBestFitFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100668798);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100668799);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100668800);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100668801);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100668802);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100668803);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_TryBestFit_Private_Char_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100668804);
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x000B99C4 File Offset: 0x000B7BC4
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362243, XrefRangeEnd = 1362252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000B99F8 File Offset: 0x000B7BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1362268, RefRangeEnd = 1362269, XrefRangeStart = 1362252, XrefRangeEnd = 1362268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_InternalDecoderBestFitFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000B9A44 File Offset: 0x000B7C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362269, XrefRangeEnd = 1362270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(Il2CppStructArray<byte> bytesUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesUnknown);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000B9AA0 File Offset: 0x000B7CA0
		[CallerCount(0)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x000B9ADC File Offset: 0x000B7CDC
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000B9B18 File Offset: 0x000B7D18
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000B9B4C File Offset: 0x000B7D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int InternalFallback(Il2CppStructArray<byte> bytes, byte* pBytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000B9BA8 File Offset: 0x000B7DA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1362271, RefRangeEnd = 1362272, XrefRangeStart = 1362270, XrefRangeEnd = 1362271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char TryBestFit(Il2CppStructArray<byte> bytesCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_TryBestFit_Private_Char_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0000A7BA File Offset: 0x000089BA
		public InternalDecoderBestFitFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x000B9BF8 File Offset: 0x000B7DF8
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x0000A7C3 File Offset: 0x000089C3
		public unsafe char _cBestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__cBestFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__cBestFit)) = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x000B9C20 File Offset: 0x000B7E20
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x0000A7DE File Offset: 0x000089DE
		public unsafe int _iCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__iCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__iCount)) = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x000B9C48 File Offset: 0x000B7E48
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x0000A7F9 File Offset: 0x000089F9
		public unsafe int _iSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__iSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__iSize)) = value;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x000B9C70 File Offset: 0x000B7E70
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x0000A814 File Offset: 0x00008A14
		public unsafe InternalDecoderBestFitFallback _oFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__oFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalDecoderBestFitFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr__oFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x000B9CA0 File Offset: 0x000B7EA0
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x0000A833 File Offset: 0x00008A33
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeFieldInfoPtr__cBestFit;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeFieldInfoPtr__iCount;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeFieldInfoPtr__iSize;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeFieldInfoPtr__oFallback;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InternalDecoderBestFitFallback_0;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeMethodInfoPtr_TryBestFit_Private_Char_Il2CppStructArray_1_Byte_0;
	}
}
