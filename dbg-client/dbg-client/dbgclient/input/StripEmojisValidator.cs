using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;

namespace dbgclient.input
{
	// Token: 0x020000B2 RID: 178
	public class StripEmojisValidator : TMP_InputValidator
	{
		// Token: 0x06000725 RID: 1829 RVA: 0x000340F8 File Offset: 0x000322F8
		// Note: this type is marked as 'beforefieldinit'.
		static StripEmojisValidator()
		{
			Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.input", "StripEmojisValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr);
			StripEmojisValidator.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, "inputField");
			StripEmojisValidator.NativeFieldInfoPtr_startSelectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, "startSelectIndex");
			StripEmojisValidator.NativeFieldInfoPtr_endSelectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, "endSelectIndex");
			StripEmojisValidator.NativeMethodInfoPtr_get_isSelected_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, 100664393);
			StripEmojisValidator.NativeMethodInfoPtr_Init_Public_Void_TMP_InputField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, 100664394);
			StripEmojisValidator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, 100664395);
			StripEmojisValidator.NativeMethodInfoPtr_DelayedAddListeners_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, 100664396);
			StripEmojisValidator.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, 100664397);
			StripEmojisValidator.NativeMethodInfoPtr_onTextSelection_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, 100664398);
			StripEmojisValidator.NativeMethodInfoPtr_onEndTextSelection_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, 100664399);
			StripEmojisValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Char_byref_String_byref_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, 100664400);
			StripEmojisValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, 100664401);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00034218 File Offset: 0x00032418
		public unsafe bool isSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator.NativeMethodInfoPtr_get_isSelected_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00034254 File Offset: 0x00032454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(TMP_InputField field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator.NativeMethodInfoPtr_Init_Public_Void_TMP_InputField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00034298 File Offset: 0x00032498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504053, XrefRangeEnd = 504062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000342CC File Offset: 0x000324CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504062, XrefRangeEnd = 504067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedAddListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator.NativeMethodInfoPtr_DelayedAddListeners_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0003430C File Offset: 0x0003250C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504067, XrefRangeEnd = 504087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00034340 File Offset: 0x00032540
		[CallerCount(0)]
		public unsafe void onTextSelection(string text, int startSelectionIndex, int endSelectionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startSelectionIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endSelectionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator.NativeMethodInfoPtr_onTextSelection_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000343A0 File Offset: 0x000325A0
		[CallerCount(0)]
		public unsafe void onEndTextSelection(string text, int startSelectionIndex, int endSelectionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startSelectionIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endSelectionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator.NativeMethodInfoPtr_onEndTextSelection_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00034400 File Offset: 0x00032600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504087, XrefRangeEnd = 504097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char Validate(ref string text, ref int pos, char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StripEmojisValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Char_byref_String_byref_Int32_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			text = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00034484 File Offset: 0x00032684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504097, XrefRangeEnd = 504098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StripEmojisValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00005459 File Offset: 0x00003659
		public StripEmojisValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x000344C0 File Offset: 0x000326C0
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00005462 File Offset: 0x00003662
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x000344F0 File Offset: 0x000326F0
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00005481 File Offset: 0x00003681
		public unsafe int startSelectIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator.NativeFieldInfoPtr_startSelectIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator.NativeFieldInfoPtr_startSelectIndex)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00034518 File Offset: 0x00032718
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0000549C File Offset: 0x0000369C
		public unsafe int endSelectIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator.NativeFieldInfoPtr_endSelectIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator.NativeFieldInfoPtr_endSelectIndex)) = value;
			}
		}

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr_startSelectIndex;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr_endSelectIndex;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelected_Private_get_Boolean_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_TMP_InputField_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_DelayedAddListeners_Private_IEnumerator_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_onTextSelection_Private_Void_String_Int32_Int32_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_onEndTextSelection_Private_Void_String_Int32_Int32_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Char_byref_String_byref_Int32_Char_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200031C RID: 796
		[ObfuscatedName("dbgclient.input.StripEmojisValidator+<DelayedAddListeners>d__7")]
		public sealed class _DelayedAddListeners_d__7 : Object
		{
			// Token: 0x0600258B RID: 9611 RVA: 0x00098C20 File Offset: 0x00096E20
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedAddListeners_d__7()
			{
				Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StripEmojisValidator>.NativeClassPtr, "<DelayedAddListeners>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr);
				StripEmojisValidator._DelayedAddListeners_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr, "<>1__state");
				StripEmojisValidator._DelayedAddListeners_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr, "<>2__current");
				StripEmojisValidator._DelayedAddListeners_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr, "<>4__this");
				StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr, 100664402);
				StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr, 100664403);
				StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr, 100664404);
				StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr, 100664405);
				StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr, 100664406);
				StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr, 100664407);
			}

			// Token: 0x0600258C RID: 9612 RVA: 0x00098D00 File Offset: 0x00096F00
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedAddListeners_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StripEmojisValidator._DelayedAddListeners_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600258D RID: 9613 RVA: 0x00098D48 File Offset: 0x00096F48
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600258E RID: 9614 RVA: 0x00098D7C File Offset: 0x00096F7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504042, XrefRangeEnd = 504048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x0600258F RID: 9615 RVA: 0x00098DB8 File Offset: 0x00096FB8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002590 RID: 9616 RVA: 0x00098DF8 File Offset: 0x00096FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504048, XrefRangeEnd = 504053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A5A RID: 2650
			// (get) Token: 0x06002591 RID: 9617 RVA: 0x00098E2C File Offset: 0x0009702C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StripEmojisValidator._DelayedAddListeners_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002592 RID: 9618 RVA: 0x000137EF File Offset: 0x000119EF
			public _DelayedAddListeners_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A56 RID: 2646
			// (get) Token: 0x06002593 RID: 9619 RVA: 0x00098E6C File Offset: 0x0009706C
			// (set) Token: 0x06002594 RID: 9620 RVA: 0x000137F8 File Offset: 0x000119F8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator._DelayedAddListeners_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator._DelayedAddListeners_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A57 RID: 2647
			// (get) Token: 0x06002595 RID: 9621 RVA: 0x00098E94 File Offset: 0x00097094
			// (set) Token: 0x06002596 RID: 9622 RVA: 0x00013813 File Offset: 0x00011A13
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator._DelayedAddListeners_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator._DelayedAddListeners_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A58 RID: 2648
			// (get) Token: 0x06002597 RID: 9623 RVA: 0x00098EC4 File Offset: 0x000970C4
			// (set) Token: 0x06002598 RID: 9624 RVA: 0x00013832 File Offset: 0x00011A32
			public unsafe StripEmojisValidator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator._DelayedAddListeners_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StripEmojisValidator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StripEmojisValidator._DelayedAddListeners_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400178F RID: 6031
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001790 RID: 6032
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001791 RID: 6033
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001792 RID: 6034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001793 RID: 6035
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001794 RID: 6036
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001795 RID: 6037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001796 RID: 6038
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001797 RID: 6039
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
