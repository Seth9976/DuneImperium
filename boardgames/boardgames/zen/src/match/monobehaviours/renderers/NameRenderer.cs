using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using TMPro;

namespace zen.src.match.monobehaviours.renderers
{
	// Token: 0x0200007A RID: 122
	public class NameRenderer : Observer
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x000246AC File Offset: 0x000228AC
		// Note: this type is marked as 'beforefieldinit'.
		static NameRenderer()
		{
			Il2CppClassPointerStore<NameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours.renderers", "NameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameRenderer>.NativeClassPtr);
			NameRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameRenderer>.NativeClassPtr, "text");
			NameRenderer.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameRenderer>.NativeClassPtr, "displayName");
			NameRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameRenderer>.NativeClassPtr, 100664278);
			NameRenderer.NativeMethodInfoPtr_ConstructDisplayName_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameRenderer>.NativeClassPtr, 100664279);
			NameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameRenderer>.NativeClassPtr, 100664280);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00024740 File Offset: 0x00022940
		[CallerCount(0)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0002477C File Offset: 0x0002297C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988526, XrefRangeEnd = 988540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ConstructDisplayName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameRenderer.NativeMethodInfoPtr_ConstructDisplayName_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000247C0 File Offset: 0x000229C0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00004DF2 File Offset: 0x00002FF2
		public NameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x000247FC File Offset: 0x000229FC
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00004DFB File Offset: 0x00002FFB
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0002482C File Offset: 0x00022A2C
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00004E1A File Offset: 0x0000301A
		public unsafe string displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameRenderer.NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameRenderer.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_displayName;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_ConstructDisplayName_Protected_Virtual_New_String_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
