using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMono
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct RuntimeGenericParamInfoHandle
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000260D4 File Offset: 0x000242D4
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeGenericParamInfoHandle()
		{
			Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeGenericParamInfoHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr);
			RuntimeGenericParamInfoHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, "value");
			RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663394);
			RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_get_Attributes_Internal_get_GenericParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663395);
			RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_GetConstraints_Private_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663396);
			RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_GetConstraintsCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663397);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00026168 File Offset: 0x00024368
		public unsafe Il2CppReferenceArray<Type> Constraints
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1275919, RefRangeEnd = 1275920, XrefRangeStart = 1275918, XrefRangeEnd = 1275919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_Type_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0002619C File Offset: 0x0002439C
		public unsafe GenericParameterAttributes Attributes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1275920, RefRangeEnd = 1275922, XrefRangeStart = 1275920, XrefRangeEnd = 1275920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_get_Attributes_Internal_get_GenericParameterAttributes_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000261CC File Offset: 0x000243CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275932, RefRangeEnd = 1275933, XrefRangeStart = 1275922, XrefRangeEnd = 1275932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Type> GetConstraints()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_GetConstraints_Private_Il2CppReferenceArray_1_Type_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00026200 File Offset: 0x00024400
		[CallerCount(0)]
		public unsafe int GetConstraintsCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGenericParamInfoHandle.NativeMethodInfoPtr_GetConstraintsCount_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000021C3 File Offset: 0x000003C3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Internal_get_GenericParameterAttributes_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_GetConstraints_Private_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_GetConstraintsCount_Private_Int32_0;

		// Token: 0x0400002A RID: 42
		[FieldOffset(0)]
		public IntPtr value;
	}
}
