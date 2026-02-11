using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000143 RID: 323
	public class MonoTypeInfo : Object
	{
		// Token: 0x06001678 RID: 5752 RVA: 0x00092408 File Offset: 0x00090608
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTypeInfo()
		{
			Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr);
			MonoTypeInfo.NativeFieldInfoPtr_full_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr, "full_name");
			MonoTypeInfo.NativeFieldInfoPtr_default_ctor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr, "default_ctor");
			MonoTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr, 100667282);
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00092474 File Offset: 0x00090674
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00006FA9 File Offset: 0x000051A9
		public MonoTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x000924B0 File Offset: 0x000906B0
		// (set) Token: 0x0600167C RID: 5756 RVA: 0x00006FB2 File Offset: 0x000051B2
		public unsafe string full_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_full_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_full_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x000924D8 File Offset: 0x000906D8
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x00006FD1 File Offset: 0x000051D1
		public unsafe RuntimeConstructorInfo default_ctor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_default_ctor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_default_ctor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeFieldInfoPtr_full_name;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeFieldInfoPtr_default_ctor;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
