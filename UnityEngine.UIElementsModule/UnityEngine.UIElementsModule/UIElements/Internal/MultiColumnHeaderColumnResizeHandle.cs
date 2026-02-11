using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements.Internal
{
	// Token: 0x020002B3 RID: 691
	public class MultiColumnHeaderColumnResizeHandle : VisualElement
	{
		// Token: 0x060033AC RID: 13228 RVA: 0x000D9A20 File Offset: 0x000D7C20
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnHeaderColumnResizeHandle()
		{
			Il2CppClassPointerStore<MultiColumnHeaderColumnResizeHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Internal", "MultiColumnHeaderColumnResizeHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnHeaderColumnResizeHandle>.NativeClassPtr);
			MultiColumnHeaderColumnResizeHandle.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnResizeHandle>.NativeClassPtr, "ussClassName");
			MultiColumnHeaderColumnResizeHandle.NativeFieldInfoPtr_dragAreaUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnResizeHandle>.NativeClassPtr, "dragAreaUssClassName");
			MultiColumnHeaderColumnResizeHandle.NativeFieldInfoPtr__dragArea_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnResizeHandle>.NativeClassPtr, "<dragArea>k__BackingField");
			MultiColumnHeaderColumnResizeHandle.NativeMethodInfoPtr_get_dragArea_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnResizeHandle>.NativeClassPtr, 100670780);
			MultiColumnHeaderColumnResizeHandle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnResizeHandle>.NativeClassPtr, 100670781);
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x000D9AB4 File Offset: 0x000D7CB4
		public unsafe VisualElement dragArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnResizeHandle.NativeMethodInfoPtr_get_dragArea_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x000D9AF4 File Offset: 0x000D7CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362153, RefRangeEnd = 362154, XrefRangeStart = 362122, XrefRangeEnd = 362153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnHeaderColumnResizeHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnHeaderColumnResizeHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnResizeHandle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x00014EC7 File Offset: 0x000130C7
		public MultiColumnHeaderColumnResizeHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x060033B0 RID: 13232 RVA: 0x000D9B30 File Offset: 0x000D7D30
		// (set) Token: 0x060033B1 RID: 13233 RVA: 0x00014ED0 File Offset: 0x000130D0
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnResizeHandle.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnResizeHandle.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x060033B2 RID: 13234 RVA: 0x000D9B50 File Offset: 0x000D7D50
		// (set) Token: 0x060033B3 RID: 13235 RVA: 0x00014EE2 File Offset: 0x000130E2
		public unsafe static string dragAreaUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnResizeHandle.NativeFieldInfoPtr_dragAreaUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnResizeHandle.NativeFieldInfoPtr_dragAreaUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x060033B4 RID: 13236 RVA: 0x000D9B70 File Offset: 0x000D7D70
		// (set) Token: 0x060033B5 RID: 13237 RVA: 0x00014EF4 File Offset: 0x000130F4
		public unsafe VisualElement _dragArea_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumnResizeHandle.NativeFieldInfoPtr__dragArea_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumnResizeHandle.NativeFieldInfoPtr__dragArea_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025D9 RID: 9689
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040025DA RID: 9690
		private static readonly IntPtr NativeFieldInfoPtr_dragAreaUssClassName;

		// Token: 0x040025DB RID: 9691
		private static readonly IntPtr NativeFieldInfoPtr__dragArea_k__BackingField;

		// Token: 0x040025DC RID: 9692
		private static readonly IntPtr NativeMethodInfoPtr_get_dragArea_Public_get_VisualElement_0;

		// Token: 0x040025DD RID: 9693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
