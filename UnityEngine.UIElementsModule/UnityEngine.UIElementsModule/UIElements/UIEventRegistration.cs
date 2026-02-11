using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E4 RID: 484
	public static class UIEventRegistration : Object
	{
		// Token: 0x0600264B RID: 9803 RVA: 0x000AA7EC File Offset: 0x000A89EC
		// Note: this type is marked as 'beforefieldinit'.
		static UIEventRegistration()
		{
			Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIEventRegistration");
			UIEventRegistration.NativeFieldInfoPtr_s_Utilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, "s_Utilities");
			UIEventRegistration.NativeMethodInfoPtr_RegisterUIElementSystem_Internal_Static_Void_IUIElementsUtility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100669103);
			UIEventRegistration.NativeMethodInfoPtr_TakeCapture_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100669104);
			UIEventRegistration.NativeMethodInfoPtr_ReleaseCapture_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100669105);
			UIEventRegistration.NativeMethodInfoPtr_EndContainerGUIFromException_Private_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100669106);
			UIEventRegistration.NativeMethodInfoPtr_ProcessEvent_Private_Static_Boolean_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100669107);
			UIEventRegistration.NativeMethodInfoPtr_CleanupRoots_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100669108);
			UIEventRegistration.NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100669109);
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x000AA8B4 File Offset: 0x000A8AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341773, XrefRangeEnd = 341781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterUIElementSystem(IUIElementsUtility utility)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(utility);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_RegisterUIElementSystem_Internal_Static_Void_IUIElementsUtility_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x000AA8EC File Offset: 0x000A8AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341804, RefRangeEnd = 341805, XrefRangeStart = 341781, XrefRangeEnd = 341804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TakeCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_TakeCapture_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x000AA914 File Offset: 0x000A8B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341828, RefRangeEnd = 341829, XrefRangeStart = 341805, XrefRangeEnd = 341828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_ReleaseCapture_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000AA93C File Offset: 0x000A8B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341857, RefRangeEnd = 341858, XrefRangeStart = 341829, XrefRangeEnd = 341857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndContainerGUIFromException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_EndContainerGUIFromException_Private_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x000AA980 File Offset: 0x000A8B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341882, RefRangeEnd = 341883, XrefRangeStart = 341858, XrefRangeEnd = 341882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeEventPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_ProcessEvent_Private_Static_Boolean_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000AA9CC File Offset: 0x000A8BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341906, RefRangeEnd = 341907, XrefRangeStart = 341883, XrefRangeEnd = 341906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupRoots()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_CleanupRoots_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000AA9F4 File Offset: 0x000A8BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341930, RefRangeEnd = 341931, XrefRangeStart = 341907, XrefRangeEnd = 341930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeCurrentIMGUIContainerDirty()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x0000F8EB File Offset: 0x0000DAEB
		public UIEventRegistration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x000AAA1C File Offset: 0x000A8C1C
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x0000F8F4 File Offset: 0x0000DAF4
		public unsafe static List<IUIElementsUtility> s_Utilities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIEventRegistration.NativeFieldInfoPtr_s_Utilities, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IUIElementsUtility>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIEventRegistration.NativeFieldInfoPtr_s_Utilities, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000AAA44 File Offset: 0x000A8C44
		public static void UpdateSchedulers()
		{
			List<IUIElementsUtility>.Enumerator enumerator = UIEventRegistration.s_Utilities.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					IUIElementsUtility iuielementsUtility = enumerator.Current;
					iuielementsUtility.UpdateSchedulers();
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000AAA9C File Offset: 0x000A8C9C
		public static void RequestRepaintForPanels(Action<ScriptableObject> repaintCallback)
		{
			List<IUIElementsUtility>.Enumerator enumerator = UIEventRegistration.s_Utilities.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					IUIElementsUtility iuielementsUtility = enumerator.Current;
					iuielementsUtility.RequestRepaintForPanels(repaintCallback);
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeFieldInfoPtr_s_Utilities;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUIElementSystem_Internal_Static_Void_IUIElementsUtility_0;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_TakeCapture_Private_Static_Void_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCapture_Private_Static_Void_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_EndContainerGUIFromException_Private_Static_Boolean_Exception_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Private_Static_Boolean_Int32_IntPtr_0;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRoots_Private_Static_Void_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Internal_Static_Void_0;

		// Token: 0x020004ED RID: 1261
		[ObfuscatedName("UnityEngine.UIElements.UIEventRegistration+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003F50 RID: 16208 RVA: 0x000FC3D8 File Offset: 0x000FA5D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr);
				UIEventRegistration.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, "<>9");
				UIEventRegistration.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100669111);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100669112);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100669113);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_2_Internal_Boolean_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100669114);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100669115);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_4_Internal_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100669116);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100669117);
			}

			// Token: 0x06003F51 RID: 16209 RVA: 0x000FC4A4 File Offset: 0x000FA6A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F52 RID: 16210 RVA: 0x000FC4E0 File Offset: 0x000FA6E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341749, XrefRangeEnd = 341753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__1_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F53 RID: 16211 RVA: 0x000FC514 File Offset: 0x000FA714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341753, XrefRangeEnd = 341757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__1_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F54 RID: 16212 RVA: 0x000FC548 File Offset: 0x000FA748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341757, XrefRangeEnd = 341761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__1_2(int i, IntPtr ptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr2;
				checked
				{
					ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr2 = ref i;
				}
				ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_2_Internal_Boolean_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003F55 RID: 16213 RVA: 0x000FC5A0 File Offset: 0x000FA7A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341761, XrefRangeEnd = 341765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__1_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F56 RID: 16214 RVA: 0x000FC5D4 File Offset: 0x000FA7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341765, XrefRangeEnd = 341769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__1_4(Exception exception)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_4_Internal_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003F57 RID: 16215 RVA: 0x000FC624 File Offset: 0x000FA824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341769, XrefRangeEnd = 341773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__1_5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F58 RID: 16216 RVA: 0x0001A946 File Offset: 0x00018B46
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001301 RID: 4865
			// (get) Token: 0x06003F59 RID: 16217 RVA: 0x000FC658 File Offset: 0x000FA858
			// (set) Token: 0x06003F5A RID: 16218 RVA: 0x0001A94F File Offset: 0x00018B4F
			public unsafe static UIEventRegistration.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIEventRegistration.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIEventRegistration.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIEventRegistration.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CBC RID: 11452
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002CBD RID: 11453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002CBE RID: 11454
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_0_Internal_Void_0;

			// Token: 0x04002CBF RID: 11455
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_1_Internal_Void_0;

			// Token: 0x04002CC0 RID: 11456
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_2_Internal_Boolean_Int32_IntPtr_0;

			// Token: 0x04002CC1 RID: 11457
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_3_Internal_Void_0;

			// Token: 0x04002CC2 RID: 11458
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_4_Internal_Boolean_Exception_0;

			// Token: 0x04002CC3 RID: 11459
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_5_Internal_Void_0;
		}

		// Token: 0x020004EE RID: 1262
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
