using System;
using Canis.context.contextToList;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.context.propertiesphrases
{
	// Token: 0x0200013E RID: 318
	[Serializable]
	public class ContextualPlaymat : ContextToList<Entity>
	{
		// Token: 0x06000E50 RID: 3664 RVA: 0x000560C4 File Offset: 0x000542C4
		// Note: this type is marked as 'beforefieldinit'.
		static ContextualPlaymat()
		{
			Il2CppClassPointerStore<ContextualPlaymat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "ContextualPlaymat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualPlaymat>.NativeClassPtr);
			ContextualPlaymat.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualPlaymat>.NativeClassPtr, "Instance");
			ContextualPlaymat.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualPlaymat>.NativeClassPtr, 100666413);
			ContextualPlaymat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualPlaymat>.NativeClassPtr, 100666414);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00056130 File Offset: 0x00054330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577353, XrefRangeEnd = 577369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Entity> Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextualPlaymat.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0005618C File Offset: 0x0005438C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577369, XrefRangeEnd = 577372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextualPlaymat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextualPlaymat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualPlaymat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000073E1 File Offset: 0x000055E1
		public ContextualPlaymat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x000561C8 File Offset: 0x000543C8
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x000073EA File Offset: 0x000055EA
		public unsafe static ContextualPlaymat Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContextualPlaymat.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextualPlaymat>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContextualPlaymat.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
