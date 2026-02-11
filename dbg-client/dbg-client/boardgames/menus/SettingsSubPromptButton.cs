using System;
using boardgames.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames.menus
{
	// Token: 0x020001AD RID: 429
	public class SettingsSubPromptButton : MonoBehaviour
	{
		// Token: 0x0600133D RID: 4925 RVA: 0x0005BE58 File Offset: 0x0005A058
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSubPromptButton()
		{
			Il2CppClassPointerStore<SettingsSubPromptButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "SettingsSubPromptButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSubPromptButton>.NativeClassPtr);
			SettingsSubPromptButton.NativeFieldInfoPtr_settingsPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSubPromptButton>.NativeClassPtr, "settingsPrompt");
			SettingsSubPromptButton.NativeFieldInfoPtr_settingsTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSubPromptButton>.NativeClassPtr, "settingsTab");
			SettingsSubPromptButton.NativeFieldInfoPtr_promptFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSubPromptButton>.NativeClassPtr, "promptFlavor");
			SettingsSubPromptButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSubPromptButton>.NativeClassPtr, 100666144);
			SettingsSubPromptButton.NativeMethodInfoPtr_ShowPrompt_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSubPromptButton>.NativeClassPtr, 100666145);
			SettingsSubPromptButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSubPromptButton>.NativeClassPtr, 100666146);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0005BF00 File Offset: 0x0005A100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519257, XrefRangeEnd = 519263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSubPromptButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0005BF34 File Offset: 0x0005A134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519263, XrefRangeEnd = 519268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSubPromptButton.NativeMethodInfoPtr_ShowPrompt_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0005BF74 File Offset: 0x0005A174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519268, XrefRangeEnd = 519272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsSubPromptButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSubPromptButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSubPromptButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0000B04A File Offset: 0x0000924A
		public SettingsSubPromptButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x0005BFB0 File Offset: 0x0005A1B0
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x0000B053 File Offset: 0x00009253
		public unsafe DismissablePromptBehaviour settingsPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton.NativeFieldInfoPtr_settingsPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DismissablePromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton.NativeFieldInfoPtr_settingsPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0005BFE0 File Offset: 0x0005A1E0
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x0000B072 File Offset: 0x00009272
		public unsafe SettingsPromptTab settingsTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton.NativeFieldInfoPtr_settingsTab);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton.NativeFieldInfoPtr_settingsTab)) = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x0005C008 File Offset: 0x0005A208
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x0000B08D File Offset: 0x0000928D
		public unsafe string promptFlavor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton.NativeFieldInfoPtr_promptFlavor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton.NativeFieldInfoPtr_promptFlavor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeFieldInfoPtr_settingsPrompt;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeFieldInfoPtr_settingsTab;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavor;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnClick_Public_Void_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_ShowPrompt_Private_IEnumerator_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A6 RID: 934
		[ObfuscatedName("boardgames.menus.SettingsSubPromptButton+<ShowPrompt>d__4")]
		public sealed class _ShowPrompt_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06002BCC RID: 11212 RVA: 0x000AB794 File Offset: 0x000A9994
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowPrompt_d__4()
			{
				Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsSubPromptButton>.NativeClassPtr, "<ShowPrompt>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr);
				SettingsSubPromptButton._ShowPrompt_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr, "<>1__state");
				SettingsSubPromptButton._ShowPrompt_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr, "<>2__current");
				SettingsSubPromptButton._ShowPrompt_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr, "<>4__this");
				SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr, 100666147);
				SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr, 100666148);
				SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr, 100666149);
				SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr, 100666150);
				SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr, 100666151);
				SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr, 100666152);
			}

			// Token: 0x06002BCD RID: 11213 RVA: 0x000AB874 File Offset: 0x000A9A74
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowPrompt_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSubPromptButton._ShowPrompt_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BCE RID: 11214 RVA: 0x000AB8BC File Offset: 0x000A9ABC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BCF RID: 11215 RVA: 0x000AB8F0 File Offset: 0x000A9AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519233, XrefRangeEnd = 519252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C6E RID: 3182
			// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x000AB92C File Offset: 0x000A9B2C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BD1 RID: 11217 RVA: 0x000AB96C File Offset: 0x000A9B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519252, XrefRangeEnd = 519257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C6F RID: 3183
			// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x000AB9A0 File Offset: 0x000A9BA0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSubPromptButton._ShowPrompt_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BD3 RID: 11219 RVA: 0x00016AA2 File Offset: 0x00014CA2
			public _ShowPrompt_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C6B RID: 3179
			// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000AB9E0 File Offset: 0x000A9BE0
			// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x00016AAB File Offset: 0x00014CAB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton._ShowPrompt_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton._ShowPrompt_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C6C RID: 3180
			// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000ABA08 File Offset: 0x000A9C08
			// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x00016AC6 File Offset: 0x00014CC6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton._ShowPrompt_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton._ShowPrompt_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C6D RID: 3181
			// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000ABA38 File Offset: 0x000A9C38
			// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x00016AE5 File Offset: 0x00014CE5
			public unsafe SettingsSubPromptButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton._ShowPrompt_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsSubPromptButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSubPromptButton._ShowPrompt_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B45 RID: 6981
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B46 RID: 6982
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B47 RID: 6983
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B48 RID: 6984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B49 RID: 6985
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B4A RID: 6986
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B4B RID: 6987
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B4C RID: 6988
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B4D RID: 6989
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
