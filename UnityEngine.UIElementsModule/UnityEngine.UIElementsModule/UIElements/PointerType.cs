using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000111 RID: 273
	public static class PointerType : Object
	{
		// Token: 0x060014E7 RID: 5351 RVA: 0x00067028 File Offset: 0x00065228
		// Note: this type is marked as 'beforefieldinit'.
		static PointerType()
		{
			Il2CppClassPointerStore<PointerType>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerType>.NativeClassPtr);
			PointerType.NativeFieldInfoPtr_mouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerType>.NativeClassPtr, "mouse");
			PointerType.NativeFieldInfoPtr_touch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerType>.NativeClassPtr, "touch");
			PointerType.NativeFieldInfoPtr_pen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerType>.NativeClassPtr, "pen");
			PointerType.NativeFieldInfoPtr_unknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerType>.NativeClassPtr, "unknown");
			PointerType.NativeMethodInfoPtr_GetPointerType_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerType>.NativeClassPtr, 100666369);
			PointerType.NativeMethodInfoPtr_IsDirectManipulationDevice_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerType>.NativeClassPtr, 100666370);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000670D0 File Offset: 0x000652D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315932, RefRangeEnd = 315933, XrefRangeStart = 315922, XrefRangeEnd = 315932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPointerType(int pointerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerType.NativeMethodInfoPtr_GetPointerType_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00067108 File Offset: 0x00065308
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315937, RefRangeEnd = 315939, XrefRangeStart = 315933, XrefRangeEnd = 315937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDirectManipulationDevice(string pointerType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pointerType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerType.NativeMethodInfoPtr_IsDirectManipulationDevice_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00009E06 File Offset: 0x00008006
		public PointerType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x0006714C File Offset: 0x0006534C
		// (set) Token: 0x060014EC RID: 5356 RVA: 0x00009E0F File Offset: 0x0000800F
		public unsafe static string mouse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerType.NativeFieldInfoPtr_mouse, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerType.NativeFieldInfoPtr_mouse, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0006716C File Offset: 0x0006536C
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x00009E21 File Offset: 0x00008021
		public unsafe static string touch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerType.NativeFieldInfoPtr_touch, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerType.NativeFieldInfoPtr_touch, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0006718C File Offset: 0x0006538C
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x00009E33 File Offset: 0x00008033
		public unsafe static string pen
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerType.NativeFieldInfoPtr_pen, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerType.NativeFieldInfoPtr_pen, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x000671AC File Offset: 0x000653AC
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x00009E45 File Offset: 0x00008045
		public unsafe static string unknown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerType.NativeFieldInfoPtr_unknown, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerType.NativeFieldInfoPtr_unknown, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeFieldInfoPtr_mouse;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeFieldInfoPtr_touch;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeFieldInfoPtr_pen;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeFieldInfoPtr_unknown;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerType_Internal_Static_String_Int32_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectManipulationDevice_Internal_Static_Boolean_String_0;
	}
}
