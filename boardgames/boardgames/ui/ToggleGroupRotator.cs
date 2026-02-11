using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.ui
{
	// Token: 0x02000125 RID: 293
	public class ToggleGroupRotator : MonoBehaviour
	{
		// Token: 0x06000F18 RID: 3864 RVA: 0x0003EEE8 File Offset: 0x0003D0E8
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleGroupRotator()
		{
			Il2CppClassPointerStore<ToggleGroupRotator>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "ToggleGroupRotator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleGroupRotator>.NativeClassPtr);
			ToggleGroupRotator.NativeFieldInfoPtr_toggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroupRotator>.NativeClassPtr, "toggles");
			ToggleGroupRotator.NativeMethodInfoPtr_Event_Rotate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroupRotator>.NativeClassPtr, 100665445);
			ToggleGroupRotator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroupRotator>.NativeClassPtr, 100665446);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0003EF54 File Offset: 0x0003D154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997075, XrefRangeEnd = 997121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Rotate(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroupRotator.NativeMethodInfoPtr_Event_Rotate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0003EF94 File Offset: 0x0003D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997121, XrefRangeEnd = 997126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleGroupRotator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleGroupRotator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroupRotator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000090C9 File Offset: 0x000072C9
		public ToggleGroupRotator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x0003EFD0 File Offset: 0x0003D1D0
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x000090D2 File Offset: 0x000072D2
		public unsafe Il2CppReferenceArray<Toggle> toggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroupRotator.NativeFieldInfoPtr_toggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroupRotator.NativeFieldInfoPtr_toggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_toggles;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_Event_Rotate_Public_Void_Int32_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200025E RID: 606
		[ObfuscatedName("boardgames.ui.ToggleGroupRotator+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001BC9 RID: 7113 RVA: 0x00066C80 File Offset: 0x00064E80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ToggleGroupRotator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToggleGroupRotator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleGroupRotator.__c>.NativeClassPtr);
				ToggleGroupRotator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroupRotator.__c>.NativeClassPtr, "<>9");
				ToggleGroupRotator.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroupRotator.__c>.NativeClassPtr, "<>9__1_0");
				ToggleGroupRotator.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroupRotator.__c>.NativeClassPtr, "<>9__1_1");
				ToggleGroupRotator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroupRotator.__c>.NativeClassPtr, 100665448);
				ToggleGroupRotator.__c.NativeMethodInfoPtr__Event_Rotate_b__1_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroupRotator.__c>.NativeClassPtr, 100665449);
				ToggleGroupRotator.__c.NativeMethodInfoPtr__Event_Rotate_b__1_1_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroupRotator.__c>.NativeClassPtr, 100665450);
			}

			// Token: 0x06001BCA RID: 7114 RVA: 0x00066D24 File Offset: 0x00064F24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleGroupRotator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroupRotator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BCB RID: 7115 RVA: 0x00066D60 File Offset: 0x00064F60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_Rotate_b__1_0(Toggle t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroupRotator.__c.NativeMethodInfoPtr__Event_Rotate_b__1_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BCC RID: 7116 RVA: 0x00066DB0 File Offset: 0x00064FB0
			[CallerCount(0)]
			public unsafe bool _Event_Rotate_b__1_1(Toggle t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroupRotator.__c.NativeMethodInfoPtr__Event_Rotate_b__1_1_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BCD RID: 7117 RVA: 0x0000F09F File Offset: 0x0000D29F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000833 RID: 2099
			// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00066E00 File Offset: 0x00065000
			// (set) Token: 0x06001BCF RID: 7119 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
			public unsafe static ToggleGroupRotator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroupRotator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGroupRotator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroupRotator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000834 RID: 2100
			// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00066E28 File Offset: 0x00065028
			// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x0000F0BA File Offset: 0x0000D2BA
			public unsafe static Func<Toggle, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroupRotator.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Toggle, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroupRotator.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000835 RID: 2101
			// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00066E50 File Offset: 0x00065050
			// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x0000F0CC File Offset: 0x0000D2CC
			public unsafe static Predicate<Toggle> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroupRotator.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Toggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroupRotator.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010E5 RID: 4325
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040010E6 RID: 4326
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040010E7 RID: 4327
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x040010E8 RID: 4328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010E9 RID: 4329
			private static readonly IntPtr NativeMethodInfoPtr__Event_Rotate_b__1_0_Internal_Boolean_Toggle_0;

			// Token: 0x040010EA RID: 4330
			private static readonly IntPtr NativeMethodInfoPtr__Event_Rotate_b__1_1_Internal_Boolean_Toggle_0;
		}
	}
}
