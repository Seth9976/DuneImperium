using System;
using Canis.context.contextToList;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.context.propertiesphrases
{
	// Token: 0x0200013F RID: 319
	[Serializable]
	public class ContextualSource : ContextToList<Entity>
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x000561F0 File Offset: 0x000543F0
		// Note: this type is marked as 'beforefieldinit'.
		static ContextualSource()
		{
			Il2CppClassPointerStore<ContextualSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "ContextualSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualSource>.NativeClassPtr);
			ContextualSource.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualSource>.NativeClassPtr, "Instance");
			ContextualSource.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualSource>.NativeClassPtr, 100666416);
			ContextualSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualSource>.NativeClassPtr, 100666417);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0005625C File Offset: 0x0005445C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577372, XrefRangeEnd = 577388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Entity> Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextualSource.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000562B8 File Offset: 0x000544B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577388, XrefRangeEnd = 577391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextualSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextualSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000073FC File Offset: 0x000055FC
		public ContextualSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x000562F4 File Offset: 0x000544F4
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00007405 File Offset: 0x00005605
		public unsafe static ContextualSource Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContextualSource.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextualSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContextualSource.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
