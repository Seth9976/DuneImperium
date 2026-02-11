using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000132 RID: 306
	public class NavigateFocusRing : Object
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x0006DBBC File Offset: 0x0006BDBC
		// Note: this type is marked as 'beforefieldinit'.
		static NavigateFocusRing()
		{
			Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "NavigateFocusRing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr);
			NavigateFocusRing.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, "Left");
			NavigateFocusRing.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, "Right");
			NavigateFocusRing.NativeFieldInfoPtr_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, "Up");
			NavigateFocusRing.NativeFieldInfoPtr_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, "Down");
			NavigateFocusRing.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, "Next");
			NavigateFocusRing.NativeFieldInfoPtr_Previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, "Previous");
			NavigateFocusRing.NativeFieldInfoPtr_m_Root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, "m_Root");
			NavigateFocusRing.NativeFieldInfoPtr_m_Ring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, "m_Ring");
			NavigateFocusRing.NativeMethodInfoPtr_get_focusController_Private_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, 100666696);
			NavigateFocusRing.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, 100666697);
			NavigateFocusRing.NativeMethodInfoPtr_GetFocusChangeDirection_Public_Virtual_Final_New_FocusChangeDirection_Focusable_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, 100666698);
			NavigateFocusRing.NativeMethodInfoPtr_GetNextFocusable_Public_Virtual_New_Focusable_Focusable_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, 100666699);
			NavigateFocusRing.NativeMethodInfoPtr_GetNextFocusable2D_Private_Focusable_Focusable_ChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, 100666700);
			NavigateFocusRing.NativeMethodInfoPtr_IsActive_Private_Static_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, 100666701);
			NavigateFocusRing.NativeMethodInfoPtr_IsNavigable_Private_Static_Boolean_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, 100666702);
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x0006DD18 File Offset: 0x0006BF18
		public unsafe FocusController focusController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317946, XrefRangeEnd = 317960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.NativeMethodInfoPtr_get_focusController_Private_get_FocusController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x0006DD58 File Offset: 0x0006BF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317960, XrefRangeEnd = 317983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigateFocusRing(VisualElement root)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0006DDA4 File Offset: 0x0006BFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317983, XrefRangeEnd = 318005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.NativeMethodInfoPtr_GetFocusChangeDirection_Public_Virtual_Final_New_FocusChangeDirection_Focusable_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0006DE08 File Offset: 0x0006C008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318005, XrefRangeEnd = 318019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NavigateFocusRing.NativeMethodInfoPtr_GetNextFocusable_Public_Virtual_New_Focusable_Focusable_FocusChangeDirection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x0006DE78 File Offset: 0x0006C078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318067, RefRangeEnd = 318068, XrefRangeStart = 318019, XrefRangeEnd = 318067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Focusable GetNextFocusable2D(Focusable currentFocusable, NavigateFocusRing.ChangeDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.NativeMethodInfoPtr_GetNextFocusable2D_Private_Focusable_Focusable_ChangeDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0006DEDC File Offset: 0x0006C0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318068, XrefRangeEnd = 318072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsActive(VisualElement v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.NativeMethodInfoPtr_IsActive_Private_Static_Boolean_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0006DF20 File Offset: 0x0006C120
		[CallerCount(0)]
		public unsafe static bool IsNavigable(Focusable focusable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.NativeMethodInfoPtr_IsNavigable_Private_Static_Boolean_Focusable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x0000A7FD File Offset: 0x000089FD
		public NavigateFocusRing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x0006DF64 File Offset: 0x0006C164
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x0000A806 File Offset: 0x00008A06
		public unsafe static NavigateFocusRing.ChangeDirection Left
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavigateFocusRing.NativeFieldInfoPtr_Left, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigateFocusRing.ChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigateFocusRing.NativeFieldInfoPtr_Left, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0006DF8C File Offset: 0x0006C18C
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x0000A818 File Offset: 0x00008A18
		public unsafe static NavigateFocusRing.ChangeDirection Right
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavigateFocusRing.NativeFieldInfoPtr_Right, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigateFocusRing.ChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigateFocusRing.NativeFieldInfoPtr_Right, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x0006DFB4 File Offset: 0x0006C1B4
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x0000A82A File Offset: 0x00008A2A
		public unsafe static NavigateFocusRing.ChangeDirection Up
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavigateFocusRing.NativeFieldInfoPtr_Up, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigateFocusRing.ChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigateFocusRing.NativeFieldInfoPtr_Up, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x0006DFDC File Offset: 0x0006C1DC
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x0000A83C File Offset: 0x00008A3C
		public unsafe static NavigateFocusRing.ChangeDirection Down
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavigateFocusRing.NativeFieldInfoPtr_Down, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigateFocusRing.ChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigateFocusRing.NativeFieldInfoPtr_Down, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0006E004 File Offset: 0x0006C204
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x0000A84E File Offset: 0x00008A4E
		public unsafe static FocusChangeDirection Next
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavigateFocusRing.NativeFieldInfoPtr_Next, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigateFocusRing.NativeFieldInfoPtr_Next, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x0006E02C File Offset: 0x0006C22C
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x0000A860 File Offset: 0x00008A60
		public unsafe static FocusChangeDirection Previous
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavigateFocusRing.NativeFieldInfoPtr_Previous, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigateFocusRing.NativeFieldInfoPtr_Previous, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0006E054 File Offset: 0x0006C254
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x0000A872 File Offset: 0x00008A72
		public unsafe VisualElement m_Root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.NativeFieldInfoPtr_m_Root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.NativeFieldInfoPtr_m_Root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0006E084 File Offset: 0x0006C284
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x0000A891 File Offset: 0x00008A91
		public unsafe VisualElementFocusRing m_Ring
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.NativeFieldInfoPtr_m_Ring);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementFocusRing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.NativeFieldInfoPtr_m_Ring), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeFieldInfoPtr_Left;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeFieldInfoPtr_Right;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeFieldInfoPtr_Up;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeFieldInfoPtr_Down;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeFieldInfoPtr_Previous;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeFieldInfoPtr_m_Root;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeFieldInfoPtr_m_Ring;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Private_get_FocusController_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisualElement_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusChangeDirection_Public_Virtual_Final_New_FocusChangeDirection_Focusable_EventBase_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_GetNextFocusable_Public_Virtual_New_Focusable_Focusable_FocusChangeDirection_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_GetNextFocusable2D_Private_Focusable_Focusable_ChangeDirection_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Private_Static_Boolean_VisualElement_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_IsNavigable_Private_Static_Boolean_Focusable_0;

		// Token: 0x02000466 RID: 1126
		public class ChangeDirection : FocusChangeDirection
		{
			// Token: 0x06003BEB RID: 15339 RVA: 0x0001924A File Offset: 0x0001744A
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeDirection()
			{
				Il2CppClassPointerStore<NavigateFocusRing.ChangeDirection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, "ChangeDirection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigateFocusRing.ChangeDirection>.NativeClassPtr);
				NavigateFocusRing.ChangeDirection.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing.ChangeDirection>.NativeClassPtr, 100666704);
			}

			// Token: 0x06003BEC RID: 15340 RVA: 0x000F0EFC File Offset: 0x000EF0FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317890, XrefRangeEnd = 317894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeDirection(int i)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigateFocusRing.ChangeDirection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.ChangeDirection.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003BED RID: 15341 RVA: 0x0001927E File Offset: 0x0001747E
			public ChangeDirection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002A3D RID: 10813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}

		// Token: 0x02000467 RID: 1127
		public sealed class FocusableHierarchyTraversal : ValueType
		{
			// Token: 0x06003BEE RID: 15342 RVA: 0x000F0F44 File Offset: 0x000EF144
			// Note: this type is marked as 'beforefieldinit'.
			static FocusableHierarchyTraversal()
			{
				Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigateFocusRing>.NativeClassPtr, "FocusableHierarchyTraversal");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr);
				NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_currentFocusable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, "currentFocusable");
				NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_validRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, "validRect");
				NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_firstPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, "firstPass");
				NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, "direction");
				NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_ValidateHierarchyTraversal_Private_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, 100666705);
				NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_ValidateElement_Private_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, 100666706);
				NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_Order_Private_Int32_VisualElement_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, 100666707);
				NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_StrictOrder_Private_Int32_VisualElement_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, 100666708);
				NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_StrictOrder_Private_Int32_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, 100666709);
				NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_TieBreaker_Private_Int32_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, 100666710);
				NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_GetBestOverall_Public_VisualElement_VisualElement_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr, 100666711);
			}

			// Token: 0x06003BEF RID: 15343 RVA: 0x000F104C File Offset: 0x000EF24C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 317903, RefRangeEnd = 317904, XrefRangeStart = 317894, XrefRangeEnd = 317903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ValidateHierarchyTraversal(VisualElement v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_ValidateHierarchyTraversal_Private_Boolean_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003BF0 RID: 15344 RVA: 0x000F10A0 File Offset: 0x000EF2A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 317908, RefRangeEnd = 317909, XrefRangeStart = 317904, XrefRangeEnd = 317908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ValidateElement(VisualElement v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_ValidateElement_Private_Boolean_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003BF1 RID: 15345 RVA: 0x000F10F4 File Offset: 0x000EF2F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317909, XrefRangeEnd = 317913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Order(VisualElement a, VisualElement b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_Order_Private_Int32_VisualElement_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003BF2 RID: 15346 RVA: 0x000F1158 File Offset: 0x000EF358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317913, XrefRangeEnd = 317916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int StrictOrder(VisualElement a, VisualElement b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_StrictOrder_Private_Int32_VisualElement_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003BF3 RID: 15347 RVA: 0x000F11BC File Offset: 0x000EF3BC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 317932, RefRangeEnd = 317934, XrefRangeStart = 317916, XrefRangeEnd = 317932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int StrictOrder(Rect ra, Rect rb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ra;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_StrictOrder_Private_Int32_Rect_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003BF4 RID: 15348 RVA: 0x000F1218 File Offset: 0x000EF418
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 317937, RefRangeEnd = 317938, XrefRangeStart = 317934, XrefRangeEnd = 317937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int TieBreaker(Rect ra, Rect rb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ra;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_TieBreaker_Private_Int32_Rect_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003BF5 RID: 15349 RVA: 0x000F1274 File Offset: 0x000EF474
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 317943, RefRangeEnd = 317946, XrefRangeStart = 317938, XrefRangeEnd = 317943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar = null)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(candidate);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bestSoFar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigateFocusRing.FocusableHierarchyTraversal.NativeMethodInfoPtr_GetBestOverall_Public_VisualElement_VisualElement_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}

			// Token: 0x06003BF6 RID: 15350 RVA: 0x00019287 File Offset: 0x00017487
			public FocusableHierarchyTraversal(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003BF7 RID: 15351 RVA: 0x00019290 File Offset: 0x00017490
			public FocusableHierarchyTraversal()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigateFocusRing.FocusableHierarchyTraversal>.NativeClassPtr))
			{
			}

			// Token: 0x17001232 RID: 4658
			// (get) Token: 0x06003BF8 RID: 15352 RVA: 0x000F12DC File Offset: 0x000EF4DC
			// (set) Token: 0x06003BF9 RID: 15353 RVA: 0x000192A2 File Offset: 0x000174A2
			public unsafe VisualElement currentFocusable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_currentFocusable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_currentFocusable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001233 RID: 4659
			// (get) Token: 0x06003BFA RID: 15354 RVA: 0x000F130C File Offset: 0x000EF50C
			// (set) Token: 0x06003BFB RID: 15355 RVA: 0x000192C1 File Offset: 0x000174C1
			public unsafe Rect validRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_validRect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_validRect)) = value;
				}
			}

			// Token: 0x17001234 RID: 4660
			// (get) Token: 0x06003BFC RID: 15356 RVA: 0x000F1334 File Offset: 0x000EF534
			// (set) Token: 0x06003BFD RID: 15357 RVA: 0x000192DC File Offset: 0x000174DC
			public unsafe bool firstPass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_firstPass);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_firstPass)) = value;
				}
			}

			// Token: 0x17001235 RID: 4661
			// (get) Token: 0x06003BFE RID: 15358 RVA: 0x000F135C File Offset: 0x000EF55C
			// (set) Token: 0x06003BFF RID: 15359 RVA: 0x000192F7 File Offset: 0x000174F7
			public unsafe NavigateFocusRing.ChangeDirection direction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_direction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigateFocusRing.ChangeDirection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigateFocusRing.FocusableHierarchyTraversal.NativeFieldInfoPtr_direction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A3E RID: 10814
			private static readonly IntPtr NativeFieldInfoPtr_currentFocusable;

			// Token: 0x04002A3F RID: 10815
			private static readonly IntPtr NativeFieldInfoPtr_validRect;

			// Token: 0x04002A40 RID: 10816
			private static readonly IntPtr NativeFieldInfoPtr_firstPass;

			// Token: 0x04002A41 RID: 10817
			private static readonly IntPtr NativeFieldInfoPtr_direction;

			// Token: 0x04002A42 RID: 10818
			private static readonly IntPtr NativeMethodInfoPtr_ValidateHierarchyTraversal_Private_Boolean_VisualElement_0;

			// Token: 0x04002A43 RID: 10819
			private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Private_Boolean_VisualElement_0;

			// Token: 0x04002A44 RID: 10820
			private static readonly IntPtr NativeMethodInfoPtr_Order_Private_Int32_VisualElement_VisualElement_0;

			// Token: 0x04002A45 RID: 10821
			private static readonly IntPtr NativeMethodInfoPtr_StrictOrder_Private_Int32_VisualElement_VisualElement_0;

			// Token: 0x04002A46 RID: 10822
			private static readonly IntPtr NativeMethodInfoPtr_StrictOrder_Private_Int32_Rect_Rect_0;

			// Token: 0x04002A47 RID: 10823
			private static readonly IntPtr NativeMethodInfoPtr_TieBreaker_Private_Int32_Rect_Rect_0;

			// Token: 0x04002A48 RID: 10824
			private static readonly IntPtr NativeMethodInfoPtr_GetBestOverall_Public_VisualElement_VisualElement_VisualElement_0;
		}
	}
}
