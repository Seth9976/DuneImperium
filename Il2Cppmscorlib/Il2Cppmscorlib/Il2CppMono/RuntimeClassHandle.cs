using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x0200000A RID: 10
	[StructLayout(2)]
	public struct RuntimeClassHandle
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00025E54 File Offset: 0x00024054
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeClassHandle()
		{
			Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeClassHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr);
			RuntimeClassHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, "value");
			RuntimeClassHandle.NativeMethodInfoPtr__ctor_Internal_Void_ptr_MonoClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663385);
			RuntimeClassHandle.NativeMethodInfoPtr_get_Value_Internal_get_ptr_MonoClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663387);
			RuntimeClassHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663388);
			RuntimeClassHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663389);
			RuntimeClassHandle.NativeMethodInfoPtr_GetTypeFromClass_Internal_Static_IntPtr_ptr_MonoClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663390);
			RuntimeClassHandle.NativeMethodInfoPtr_GetTypeHandle_Internal_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, 100663391);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00025F10 File Offset: 0x00024110
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr__ctor_Internal_Void_ptr_MonoClass_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00025F44 File Offset: 0x00024144
		public unsafe RuntimeStructs.MonoClass* Value
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr_get_Value_Internal_get_ptr_MonoClass_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00025F6C File Offset: 0x0002416C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275897, XrefRangeEnd = 1275908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00025FB0 File Offset: 0x000241B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275908, XrefRangeEnd = 1275910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00025FE0 File Offset: 0x000241E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275910, XrefRangeEnd = 1275911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = klass;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr_GetTypeFromClass_Internal_Static_IntPtr_ptr_MonoClass_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0002601C File Offset: 0x0002421C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1275913, RefRangeEnd = 1275918, XrefRangeStart = 1275911, XrefRangeEnd = 1275913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeTypeHandle GetTypeHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClassHandle.NativeMethodInfoPtr_GetTypeHandle_Internal_RuntimeTypeHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000219F File Offset: 0x0000039F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeClassHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_MonoClass_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Internal_get_ptr_MonoClass_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromClass_Internal_Static_IntPtr_ptr_MonoClass_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeHandle_Internal_RuntimeTypeHandle_0;

		// Token: 0x04000021 RID: 33
		[FieldOffset(0)]
		public IntPtr value;
	}
}
