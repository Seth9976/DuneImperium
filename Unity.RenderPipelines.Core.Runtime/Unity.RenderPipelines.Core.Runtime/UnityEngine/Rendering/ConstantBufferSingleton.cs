using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200003A RID: 58
	public class ConstantBufferSingleton<CBType> : ConstantBuffer<CBType> where CBType : new()
	{
		// Token: 0x060004CC RID: 1228 RVA: 0x0001F0DC File Offset: 0x0001D2DC
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantBufferSingleton()
		{
			Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ConstantBufferSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr);
			ConstantBufferSingleton<CBType>.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr, "s_Instance");
			ConstantBufferSingleton<CBType>.NativeMethodInfoPtr_get_instance_Internal_Static_get_ConstantBufferSingleton_1_CBType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr, 100663886);
			ConstantBufferSingleton<CBType>.NativeMethodInfoPtr_set_instance_Internal_Static_set_Void_ConstantBufferSingleton_1_CBType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr, 100663887);
			ConstantBufferSingleton<CBType>.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr, 100663888);
			ConstantBufferSingleton<CBType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr, 100663889);
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0001F1AC File Offset: 0x0001D3AC
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x0001F1E0 File Offset: 0x0001D3E0
		public unsafe static ConstantBufferSingleton<CBType> instance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 959355, RefRangeEnd = 959356, XrefRangeStart = 959321, XrefRangeEnd = 959355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBufferSingleton<CBType>.NativeMethodInfoPtr_get_instance_Internal_Static_get_ConstantBufferSingleton_1_CBType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstantBufferSingleton<CBType>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959356, XrefRangeEnd = 959361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBufferSingleton<CBType>.NativeMethodInfoPtr_set_instance_Internal_Static_set_Void_ConstantBufferSingleton_1_CBType_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0001F218 File Offset: 0x0001D418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959361, XrefRangeEnd = 959390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantBufferSingleton<CBType>.NativeMethodInfoPtr_Release_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0001F254 File Offset: 0x0001D454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959390, XrefRangeEnd = 959470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantBufferSingleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBufferSingleton<CBType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00003FD9 File Offset: 0x000021D9
		public ConstantBufferSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0001F290 File Offset: 0x0001D490
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00003FE2 File Offset: 0x000021E2
		public unsafe static ConstantBufferSingleton<CBType> s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConstantBufferSingleton<CBType>.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantBufferSingleton<CBType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstantBufferSingleton<CBType>.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Internal_Static_get_ConstantBufferSingleton_1_CBType_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_set_instance_Internal_Static_set_Void_ConstantBufferSingleton_1_CBType_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
