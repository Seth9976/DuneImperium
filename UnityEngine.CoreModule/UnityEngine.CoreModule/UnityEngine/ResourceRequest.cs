using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200011B RID: 283
	public class ResourceRequest : AsyncOperation
	{
		// Token: 0x060016F0 RID: 5872 RVA: 0x0006DD14 File Offset: 0x0006BF14
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceRequest()
		{
			Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ResourceRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr);
			ResourceRequest.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, "m_Path");
			ResourceRequest.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, "m_Type");
			ResourceRequest.NativeMethodInfoPtr_GetResult_Protected_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, 100666458);
			ResourceRequest.NativeMethodInfoPtr_get_asset_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, 100666459);
			ResourceRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, 100666460);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x0006DDA8 File Offset: 0x0006BFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660289, XrefRangeEnd = 660290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceRequest.NativeMethodInfoPtr_GetResult_Protected_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0006DDF4 File Offset: 0x0006BFF4
		public unsafe Object asset
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 660290, RefRangeEnd = 660296, XrefRangeStart = 660290, XrefRangeEnd = 660290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceRequest.NativeMethodInfoPtr_get_asset_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0006DE34 File Offset: 0x0006C034
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00009098 File Offset: 0x00007298
		public ResourceRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x0006DE70 File Offset: 0x0006C070
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x000090A1 File Offset: 0x000072A1
		public unsafe string m_Path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x0006DE98 File Offset: 0x0006C098
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x000090C0 File Offset: 0x000072C0
		public unsafe Type m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeFieldInfoPtr_m_Path;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Protected_Virtual_New_Object_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_get_Object_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
