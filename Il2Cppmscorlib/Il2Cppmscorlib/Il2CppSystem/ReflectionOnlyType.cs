using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000138 RID: 312
	[Serializable]
	public class ReflectionOnlyType : RuntimeType
	{
		// Token: 0x0600159B RID: 5531 RVA: 0x0008EFC0 File Offset: 0x0008D1C0
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionOnlyType()
		{
			Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ReflectionOnlyType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr);
			ReflectionOnlyType.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr, 100667162);
			ReflectionOnlyType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr, 100667163);
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0008F018 File Offset: 0x0008D218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343472, XrefRangeEnd = 1343476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionOnlyType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionOnlyType.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x0008F054 File Offset: 0x0008D254
		public unsafe override RuntimeTypeHandle TypeHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343476, XrefRangeEnd = 1343483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionOnlyType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00006AA6 File Offset: 0x00004CA6
		public ReflectionOnlyType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0;
	}
}
