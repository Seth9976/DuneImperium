using System;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.match.behaviours
{
	// Token: 0x02000283 RID: 643
	public class LocalizeByPickerKind : MonoBehaviour
	{
		// Token: 0x06001E15 RID: 7701 RVA: 0x00081DD8 File Offset: 0x0007FFD8
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeByPickerKind()
		{
			Il2CppClassPointerStore<LocalizeByPickerKind>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.behaviours", "LocalizeByPickerKind");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeByPickerKind>.NativeClassPtr);
			LocalizeByPickerKind.NativeFieldInfoPtr_defaultKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeByPickerKind>.NativeClassPtr, "defaultKey");
			LocalizeByPickerKind.NativeFieldInfoPtr_pickerKinds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeByPickerKind>.NativeClassPtr, "pickerKinds");
			LocalizeByPickerKind.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeByPickerKind>.NativeClassPtr, 100668230);
			LocalizeByPickerKind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeByPickerKind>.NativeClassPtr, 100668231);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00081E58 File Offset: 0x00080058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538376, XrefRangeEnd = 538401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeByPickerKind.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00081E8C File Offset: 0x0008008C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538401, XrefRangeEnd = 538409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeByPickerKind()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeByPickerKind>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeByPickerKind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x0000FDFC File Offset: 0x0000DFFC
		public LocalizeByPickerKind(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x00081EC8 File Offset: 0x000800C8
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x0000FE05 File Offset: 0x0000E005
		public unsafe string defaultKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeByPickerKind.NativeFieldInfoPtr_defaultKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeByPickerKind.NativeFieldInfoPtr_defaultKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00081EF0 File Offset: 0x000800F0
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x0000FE24 File Offset: 0x0000E024
		public unsafe Il2CppReferenceArray<LocalizeByPickerKind.Kind> pickerKinds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeByPickerKind.NativeFieldInfoPtr_pickerKinds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalizeByPickerKind.Kind>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeByPickerKind.NativeFieldInfoPtr_pickerKinds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeFieldInfoPtr_defaultKey;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeFieldInfoPtr_pickerKinds;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000473 RID: 1139
		[Serializable]
		public class Kind : global::Il2CppSystem.Object
		{
			// Token: 0x060035EA RID: 13802 RVA: 0x000C9874 File Offset: 0x000C7A74
			// Note: this type is marked as 'beforefieldinit'.
			static Kind()
			{
				Il2CppClassPointerStore<LocalizeByPickerKind.Kind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizeByPickerKind>.NativeClassPtr, "Kind");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeByPickerKind.Kind>.NativeClassPtr);
				LocalizeByPickerKind.Kind.NativeFieldInfoPtr_pickerKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeByPickerKind.Kind>.NativeClassPtr, "pickerKind");
				LocalizeByPickerKind.Kind.NativeFieldInfoPtr_locKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeByPickerKind.Kind>.NativeClassPtr, "locKey");
				LocalizeByPickerKind.Kind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeByPickerKind.Kind>.NativeClassPtr, 100668232);
			}

			// Token: 0x060035EB RID: 13803 RVA: 0x000C98DC File Offset: 0x000C7ADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538361, XrefRangeEnd = 538367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Kind()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeByPickerKind.Kind>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeByPickerKind.Kind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035EC RID: 13804 RVA: 0x0001BCA6 File Offset: 0x00019EA6
			public Kind(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FD2 RID: 4050
			// (get) Token: 0x060035ED RID: 13805 RVA: 0x000C9918 File Offset: 0x000C7B18
			// (set) Token: 0x060035EE RID: 13806 RVA: 0x0001BCAF File Offset: 0x00019EAF
			public unsafe string pickerKind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeByPickerKind.Kind.NativeFieldInfoPtr_pickerKind);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeByPickerKind.Kind.NativeFieldInfoPtr_pickerKind), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FD3 RID: 4051
			// (get) Token: 0x060035EF RID: 13807 RVA: 0x000C9940 File Offset: 0x000C7B40
			// (set) Token: 0x060035F0 RID: 13808 RVA: 0x0001BCCE File Offset: 0x00019ECE
			public unsafe string locKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeByPickerKind.Kind.NativeFieldInfoPtr_locKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeByPickerKind.Kind.NativeFieldInfoPtr_locKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002131 RID: 8497
			private static readonly IntPtr NativeFieldInfoPtr_pickerKind;

			// Token: 0x04002132 RID: 8498
			private static readonly IntPtr NativeFieldInfoPtr_locKey;

			// Token: 0x04002133 RID: 8499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000474 RID: 1140
		[ObfuscatedName("boardgames.match.behaviours.LocalizeByPickerKind+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060035F1 RID: 13809 RVA: 0x000C9968 File Offset: 0x000C7B68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<LocalizeByPickerKind.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizeByPickerKind>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeByPickerKind.__c__DisplayClass3_0>.NativeClassPtr);
				LocalizeByPickerKind.__c__DisplayClass3_0.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeByPickerKind.__c__DisplayClass3_0>.NativeClassPtr, "selectionResponder");
				LocalizeByPickerKind.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeByPickerKind.__c__DisplayClass3_0>.NativeClassPtr, 100668233);
				LocalizeByPickerKind.__c__DisplayClass3_0.NativeMethodInfoPtr__OnEnable_b__0_Internal_Boolean_Kind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeByPickerKind.__c__DisplayClass3_0>.NativeClassPtr, 100668234);
			}

			// Token: 0x060035F2 RID: 13810 RVA: 0x000C99D0 File Offset: 0x000C7BD0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeByPickerKind.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeByPickerKind.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035F3 RID: 13811 RVA: 0x000C9A0C File Offset: 0x000C7C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538367, XrefRangeEnd = 538376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnEnable_b__0(LocalizeByPickerKind.Kind k)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(k);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeByPickerKind.__c__DisplayClass3_0.NativeMethodInfoPtr__OnEnable_b__0_Internal_Boolean_Kind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035F4 RID: 13812 RVA: 0x0001BCED File Offset: 0x00019EED
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FD4 RID: 4052
			// (get) Token: 0x060035F5 RID: 13813 RVA: 0x000C9A5C File Offset: 0x000C7C5C
			// (set) Token: 0x060035F6 RID: 13814 RVA: 0x0001BCF6 File Offset: 0x00019EF6
			public unsafe DBGSelectionResponder selectionResponder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeByPickerKind.__c__DisplayClass3_0.NativeFieldInfoPtr_selectionResponder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeByPickerKind.__c__DisplayClass3_0.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002134 RID: 8500
			private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

			// Token: 0x04002135 RID: 8501
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002136 RID: 8502
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__0_Internal_Boolean_Kind_0;
		}
	}
}
