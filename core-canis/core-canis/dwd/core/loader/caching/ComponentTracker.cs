using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.loader.caching
{
	// Token: 0x02000187 RID: 391
	public class ComponentTracker : global::Il2CppSystem.Object
	{
		// Token: 0x06001637 RID: 5687 RVA: 0x0006D44C File Offset: 0x0006B64C
		// Note: this type is marked as 'beforefieldinit'.
		static ComponentTracker()
		{
			Il2CppClassPointerStore<ComponentTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "ComponentTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentTracker>.NativeClassPtr);
			ComponentTracker.NativeFieldInfoPtr_killed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentTracker>.NativeClassPtr, "killed");
			ComponentTracker.NativeFieldInfoPtr_component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentTracker>.NativeClassPtr, "component");
			ComponentTracker.NativeFieldInfoPtr_sourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentTracker>.NativeClassPtr, "sourceName");
			ComponentTracker.NativeMethodInfoPtr__ctor_Public_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentTracker>.NativeClassPtr, 100666703);
			ComponentTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentTracker>.NativeClassPtr, 100666704);
			ComponentTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentTracker>.NativeClassPtr, 100666705);
			ComponentTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentTracker>.NativeClassPtr, 100666706);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0006D508 File Offset: 0x0006B708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878199, XrefRangeEnd = 878204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComponentTracker(Component component)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentTracker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentTracker.NativeMethodInfoPtr__ctor_Public_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0006D554 File Offset: 0x0006B754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878204, XrefRangeEnd = 878208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StillAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0006D590 File Offset: 0x0006B790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878208, XrefRangeEnd = 878218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0006D5C8 File Offset: 0x0006B7C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00009B32 File Offset: 0x00007D32
		public ComponentTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x0006D5FC File Offset: 0x0006B7FC
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x00009B3B File Offset: 0x00007D3B
		public unsafe bool killed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentTracker.NativeFieldInfoPtr_killed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentTracker.NativeFieldInfoPtr_killed)) = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x0006D624 File Offset: 0x0006B824
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x00009B56 File Offset: 0x00007D56
		public unsafe Component component
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentTracker.NativeFieldInfoPtr_component);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentTracker.NativeFieldInfoPtr_component), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x0006D654 File Offset: 0x0006B854
		// (set) Token: 0x06001642 RID: 5698 RVA: 0x00009B75 File Offset: 0x00007D75
		public unsafe string sourceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentTracker.NativeFieldInfoPtr_sourceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComponentTracker.NativeFieldInfoPtr_sourceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeFieldInfoPtr_killed;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeFieldInfoPtr_component;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeFieldInfoPtr_sourceName;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Component_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0;
	}
}
