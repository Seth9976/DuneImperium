using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x020001F5 RID: 501
	[Serializable]
	public sealed class InternalDecoderBestFitFallback : DecoderFallback
	{
		// Token: 0x06002054 RID: 8276 RVA: 0x000B95E4 File Offset: 0x000B77E4
		// Note: this type is marked as 'beforefieldinit'.
		static InternalDecoderBestFitFallback()
		{
			Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "InternalDecoderBestFitFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr);
			InternalDecoderBestFitFallback.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, "_encoding");
			InternalDecoderBestFitFallback.NativeFieldInfoPtr__arrayBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, "_arrayBestFit");
			InternalDecoderBestFitFallback.NativeFieldInfoPtr__cReplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, "_cReplacement");
			InternalDecoderBestFitFallback.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, 100668792);
			InternalDecoderBestFitFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, 100668793);
			InternalDecoderBestFitFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, 100668794);
			InternalDecoderBestFitFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, 100668795);
			InternalDecoderBestFitFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, 100668796);
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x000B96B4 File Offset: 0x000B78B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1362236, RefRangeEnd = 1362237, XrefRangeStart = 1362234, XrefRangeEnd = 1362236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalDecoderBestFitFallback(Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallback.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x000B9700 File Offset: 0x000B7900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362237, XrefRangeEnd = 1362241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x000B9740 File Offset: 0x000B7940
		public unsafe override int MaxCharCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x000B977C File Offset: 0x000B797C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362241, XrefRangeEnd = 1362243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000B97CC File Offset: 0x000B79CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0000A758 File Offset: 0x00008958
		public InternalDecoderBestFitFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x000B9808 File Offset: 0x000B7A08
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x0000A761 File Offset: 0x00008961
		public unsafe Encoding _encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr__encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x000B9838 File Offset: 0x000B7A38
		// (set) Token: 0x0600205E RID: 8286 RVA: 0x0000A780 File Offset: 0x00008980
		public unsafe Il2CppStructArray<char> _arrayBestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr__arrayBestFit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr__arrayBestFit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x000B9868 File Offset: 0x000B7A68
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x0000A79F File Offset: 0x0000899F
		public unsafe char _cReplacement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr__cReplacement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr__cReplacement)) = value;
			}
		}

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeFieldInfoPtr__encoding;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeFieldInfoPtr__arrayBestFit;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeFieldInfoPtr__cReplacement;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
