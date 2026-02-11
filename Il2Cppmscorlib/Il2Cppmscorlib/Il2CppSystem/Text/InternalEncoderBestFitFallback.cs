using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000200 RID: 512
	[Serializable]
	public class InternalEncoderBestFitFallback : EncoderFallback
	{
		// Token: 0x060020EA RID: 8426 RVA: 0x000BBEA8 File Offset: 0x000BA0A8
		// Note: this type is marked as 'beforefieldinit'.
		static InternalEncoderBestFitFallback()
		{
			Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "InternalEncoderBestFitFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr);
			InternalEncoderBestFitFallback.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, "_encoding");
			InternalEncoderBestFitFallback.NativeFieldInfoPtr__arrayBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, "_arrayBestFit");
			InternalEncoderBestFitFallback.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, 100668872);
			InternalEncoderBestFitFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, 100668873);
			InternalEncoderBestFitFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, 100668874);
			InternalEncoderBestFitFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, 100668875);
			InternalEncoderBestFitFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, 100668876);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x000BBF64 File Offset: 0x000BA164
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalEncoderBestFitFallback(Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallback.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x000BBFB0 File Offset: 0x000BA1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362656, XrefRangeEnd = 1362660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InternalEncoderBestFitFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x000BBFFC File Offset: 0x000BA1FC
		public unsafe override int MaxCharCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InternalEncoderBestFitFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000BC044 File Offset: 0x000BA244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362660, XrefRangeEnd = 1362663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InternalEncoderBestFitFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000BC09C File Offset: 0x000BA29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InternalEncoderBestFitFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x0000AA4C File Offset: 0x00008C4C
		public InternalEncoderBestFitFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x000BC0E4 File Offset: 0x000BA2E4
		// (set) Token: 0x060020F2 RID: 8434 RVA: 0x0000AA55 File Offset: 0x00008C55
		public unsafe Encoding _encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallback.NativeFieldInfoPtr__encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallback.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x000BC114 File Offset: 0x000BA314
		// (set) Token: 0x060020F4 RID: 8436 RVA: 0x0000AA74 File Offset: 0x00008C74
		public unsafe Il2CppStructArray<char> _arrayBestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallback.NativeFieldInfoPtr__arrayBestFit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallback.NativeFieldInfoPtr__arrayBestFit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeFieldInfoPtr__encoding;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeFieldInfoPtr__arrayBestFit;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
