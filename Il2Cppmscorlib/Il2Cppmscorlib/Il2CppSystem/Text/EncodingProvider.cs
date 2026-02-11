using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200020B RID: 523
	public class EncodingProvider : Object
	{
		// Token: 0x06002192 RID: 8594 RVA: 0x000BEBA0 File Offset: 0x000BCDA0
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingProvider()
		{
			Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncodingProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr);
			EncodingProvider.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, "s_InternalSyncObject");
			EncodingProvider.NativeFieldInfoPtr_s_providers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, "s_providers");
			EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668960);
			EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668961);
			EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668962);
			EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668963);
			EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668964);
			EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668965);
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x000BEC70 File Offset: 0x000BCE70
		[CallerCount(0)]
		public unsafe virtual Encoding GetEncoding(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x000BECCC File Offset: 0x000BCECC
		[CallerCount(0)]
		public unsafe virtual Encoding GetEncoding(int codepage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x000BED24 File Offset: 0x000BCF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363099, XrefRangeEnd = 1363103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoderFallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoderFallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x000BEDA0 File Offset: 0x000BCFA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1363113, RefRangeEnd = 1363114, XrefRangeStart = 1363103, XrefRangeEnd = 1363113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncodingFromProvider(int codepage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x000BEDE0 File Offset: 0x000BCFE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1363124, RefRangeEnd = 1363125, XrefRangeStart = 1363114, XrefRangeEnd = 1363124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncodingFromProvider(string encodingName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(encodingName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x000BEE24 File Offset: 0x000BD024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1363135, RefRangeEnd = 1363136, XrefRangeStart = 1363125, XrefRangeEnd = 1363135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dec);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x0000ADBF File Offset: 0x00008FBF
		public EncodingProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x000BEE88 File Offset: 0x000BD088
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingProvider.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingProvider.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x000BEEB0 File Offset: 0x000BD0B0
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x0000ADDA File Offset: 0x00008FDA
		public unsafe static Il2CppReferenceArray<EncodingProvider> s_providers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingProvider.NativeFieldInfoPtr_s_providers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EncodingProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingProvider.NativeFieldInfoPtr_s_providers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeFieldInfoPtr_s_providers;

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0;
	}
}
