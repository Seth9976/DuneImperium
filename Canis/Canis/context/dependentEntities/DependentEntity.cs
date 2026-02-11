using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.context.dependentEntities
{
	// Token: 0x02000129 RID: 297
	public class DependentEntity : Object
	{
		// Token: 0x06000DC6 RID: 3526 RVA: 0x00054094 File Offset: 0x00052294
		// Note: this type is marked as 'beforefieldinit'.
		static DependentEntity()
		{
			Il2CppClassPointerStore<DependentEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.dependentEntities", "DependentEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DependentEntity>.NativeClassPtr);
			DependentEntity.NativeMethodInfoPtr_For_Public_Abstract_Virtual_New_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependentEntity>.NativeClassPtr, 100666352);
			DependentEntity.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependentEntity>.NativeClassPtr, 100666353);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x000540EC File Offset: 0x000522EC
		[CallerCount(0)]
		public unsafe virtual Entity For(Entity basedOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(basedOn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DependentEntity.NativeMethodInfoPtr_For_Public_Abstract_Virtual_New_Entity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00054148 File Offset: 0x00052348
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DependentEntity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DependentEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependentEntity.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0000705E File Offset: 0x0000525E
		public DependentEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_For_Public_Abstract_Virtual_New_Entity_Entity_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
