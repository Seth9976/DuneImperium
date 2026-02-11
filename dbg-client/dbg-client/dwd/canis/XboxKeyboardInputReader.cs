using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace dwd.canis
{
	// Token: 0x0200004A RID: 74
	public class XboxKeyboardInputReader : MonoBehaviour
	{
		// Token: 0x060002CE RID: 718 RVA: 0x000266E4 File Offset: 0x000248E4
		// Note: this type is marked as 'beforefieldinit'.
		static XboxKeyboardInputReader()
		{
			Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis", "XboxKeyboardInputReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr);
			XboxKeyboardInputReader.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr, "inputField");
			XboxKeyboardInputReader.NativeFieldInfoPtr_uiInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr, "uiInputField");
			XboxKeyboardInputReader.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr, "title");
			XboxKeyboardInputReader.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr, "description");
			XboxKeyboardInputReader.NativeFieldInfoPtr_entryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr, "entryType");
			XboxKeyboardInputReader.NativeFieldInfoPtr_OnDismiss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr, "OnDismiss");
			XboxKeyboardInputReader.NativeMethodInfoPtr_Event_SelectInputField_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr, 100663749);
			XboxKeyboardInputReader.NativeMethodInfoPtr_ShowKeyboard_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr, 100663750);
			XboxKeyboardInputReader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr, 100663751);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000267C8 File Offset: 0x000249C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499193, XrefRangeEnd = 499201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectInputField(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxKeyboardInputReader.NativeMethodInfoPtr_Event_SelectInputField_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0002680C File Offset: 0x00024A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499201, XrefRangeEnd = 499207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowKeyboard(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxKeyboardInputReader.NativeMethodInfoPtr_ShowKeyboard_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0002685C File Offset: 0x00024A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499207, XrefRangeEnd = 499222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxKeyboardInputReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxKeyboardInputReader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00003398 File Offset: 0x00001598
		public XboxKeyboardInputReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00026898 File Offset: 0x00024A98
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x000033A1 File Offset: 0x000015A1
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x000268C8 File Offset: 0x00024AC8
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x000033C0 File Offset: 0x000015C0
		public unsafe InputField uiInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_uiInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_uiInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x000268F8 File Offset: 0x00024AF8
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x000033DF File Offset: 0x000015DF
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00026920 File Offset: 0x00024B20
		// (set) Token: 0x060002DA RID: 730 RVA: 0x000033FE File Offset: 0x000015FE
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00026948 File Offset: 0x00024B48
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0000341D File Offset: 0x0000161D
		public unsafe InputType entryType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_entryType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_entryType)) = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00026970 File Offset: 0x00024B70
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00003438 File Offset: 0x00001638
		public unsafe UnityEvent OnDismiss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_OnDismiss);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader.NativeFieldInfoPtr_OnDismiss), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_uiInputField;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_entryType;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_OnDismiss;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectInputField_Public_Void_String_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_ShowKeyboard_Private_IEnumerator_String_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002E6 RID: 742
		[ObfuscatedName("dwd.canis.XboxKeyboardInputReader+<ShowKeyboard>d__7")]
		public sealed class _ShowKeyboard_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x060022F1 RID: 8945 RVA: 0x00090FF4 File Offset: 0x0008F1F4
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowKeyboard_d__7()
			{
				Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XboxKeyboardInputReader>.NativeClassPtr, "<ShowKeyboard>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr);
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, "<>1__state");
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, "<>2__current");
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, "<>4__this");
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, "text");
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr__command_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, "<command>5__2");
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, 100663752);
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, 100663753);
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, 100663754);
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, 100663755);
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, 100663756);
				XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr, 100663757);
			}

			// Token: 0x060022F2 RID: 8946 RVA: 0x000910FC File Offset: 0x0008F2FC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowKeyboard_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxKeyboardInputReader._ShowKeyboard_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022F3 RID: 8947 RVA: 0x00091144 File Offset: 0x0008F344
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022F4 RID: 8948 RVA: 0x00091178 File Offset: 0x0008F378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499161, XrefRangeEnd = 499188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x060022F5 RID: 8949 RVA: 0x000911B4 File Offset: 0x0008F3B4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022F6 RID: 8950 RVA: 0x000911F4 File Offset: 0x0008F3F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499188, XrefRangeEnd = 499193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000976 RID: 2422
			// (get) Token: 0x060022F7 RID: 8951 RVA: 0x00091228 File Offset: 0x0008F428
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022F8 RID: 8952 RVA: 0x00012343 File Offset: 0x00010543
			public _ShowKeyboard_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x060022F9 RID: 8953 RVA: 0x00091268 File Offset: 0x0008F468
			// (set) Token: 0x060022FA RID: 8954 RVA: 0x0001234C File Offset: 0x0001054C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000971 RID: 2417
			// (get) Token: 0x060022FB RID: 8955 RVA: 0x00091290 File Offset: 0x0008F490
			// (set) Token: 0x060022FC RID: 8956 RVA: 0x00012367 File Offset: 0x00010567
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000972 RID: 2418
			// (get) Token: 0x060022FD RID: 8957 RVA: 0x000912C0 File Offset: 0x0008F4C0
			// (set) Token: 0x060022FE RID: 8958 RVA: 0x00012386 File Offset: 0x00010586
			public unsafe XboxKeyboardInputReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XboxKeyboardInputReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000973 RID: 2419
			// (get) Token: 0x060022FF RID: 8959 RVA: 0x000912F0 File Offset: 0x0008F4F0
			// (set) Token: 0x06002300 RID: 8960 RVA: 0x000123A5 File Offset: 0x000105A5
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x06002301 RID: 8961 RVA: 0x00091318 File Offset: 0x0008F518
			// (set) Token: 0x06002302 RID: 8962 RVA: 0x000123C4 File Offset: 0x000105C4
			public unsafe IShowKeyboardCommand _command_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr__command_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IShowKeyboardCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxKeyboardInputReader._ShowKeyboard_d__7.NativeFieldInfoPtr__command_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015F7 RID: 5623
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015F8 RID: 5624
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015F9 RID: 5625
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015FA RID: 5626
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x040015FB RID: 5627
			private static readonly IntPtr NativeFieldInfoPtr__command_5__2;

			// Token: 0x040015FC RID: 5628
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015FD RID: 5629
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015FE RID: 5630
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015FF RID: 5631
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001600 RID: 5632
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001601 RID: 5633
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
