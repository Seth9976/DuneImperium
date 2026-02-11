using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000142 RID: 322
	public class IsTargeting : PropertiesPhrase
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x000566EC File Offset: 0x000548EC
		// Note: this type is marked as 'beforefieldinit'.
		static IsTargeting()
		{
			Il2CppClassPointerStore<IsTargeting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "IsTargeting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsTargeting>.NativeClassPtr);
			IsTargeting.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTargeting>.NativeClassPtr, "EntityID");
			IsTargeting.NativeMethodInfoPtr__ctor_Public_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsTargeting>.NativeClassPtr, 100666423);
			IsTargeting.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsTargeting>.NativeClassPtr, 100666424);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00056758 File Offset: 0x00054958
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IsTargeting(EntityID entityId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsTargeting>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsTargeting.NativeMethodInfoPtr__ctor_Public_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000567A4 File Offset: 0x000549A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577426, XrefRangeEnd = 577430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IsTargeting.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00007463 File Offset: 0x00005663
		public IsTargeting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x000567FC File Offset: 0x000549FC
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x0000746C File Offset: 0x0000566C
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsTargeting.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsTargeting.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;
	}
}
