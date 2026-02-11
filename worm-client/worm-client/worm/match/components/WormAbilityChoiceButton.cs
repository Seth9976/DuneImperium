using System;
using boardgames.match.selection;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match.selection;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x020001CA RID: 458
	public class WormAbilityChoiceButton : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x0600141A RID: 5146 RVA: 0x00055248 File Offset: 0x00053448
		// Note: this type is marked as 'beforefieldinit'.
		static WormAbilityChoiceButton()
		{
			Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormAbilityChoiceButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr);
			WormAbilityChoiceButton.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, "choice");
			WormAbilityChoiceButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, "button");
			WormAbilityChoiceButton.NativeFieldInfoPtr_optionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, "optionString");
			WormAbilityChoiceButton.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, "parent");
			WormAbilityChoiceButton.NativeFieldInfoPtr_confirmation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, "confirmation");
			WormAbilityChoiceButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, 100666057);
			WormAbilityChoiceButton.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, 100666058);
			WormAbilityChoiceButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, 100666059);
			WormAbilityChoiceButton.NativeMethodInfoPtr_handleSelection_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, 100666060);
			WormAbilityChoiceButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, 100666061);
			WormAbilityChoiceButton.NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_Boolean_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, 100666062);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00055354 File Offset: 0x00053554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713713, XrefRangeEnd = 713723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityChoiceButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00055390 File Offset: 0x00053590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713723, XrefRangeEnd = 713754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityChoiceButton.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x000553CC File Offset: 0x000535CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713754, XrefRangeEnd = 713760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityChoiceButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00055400 File Offset: 0x00053600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713760, XrefRangeEnd = 713765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator handleSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityChoiceButton.NativeMethodInfoPtr_handleSelection_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00055440 File Offset: 0x00053640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713765, XrefRangeEnd = 713771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAbilityChoiceButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityChoiceButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0005547C File Offset: 0x0005367C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713771, XrefRangeEnd = 713784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__6_0(ReadOnlyAttributes b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityChoiceButton.NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_Boolean_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0000C527 File Offset: 0x0000A727
		public WormAbilityChoiceButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x000554CC File Offset: 0x000536CC
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x0000C530 File Offset: 0x0000A730
		public unsafe int choice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton.NativeFieldInfoPtr_choice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton.NativeFieldInfoPtr_choice)) = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x000554F4 File Offset: 0x000536F4
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x0000C54B File Offset: 0x0000A74B
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x00055524 File Offset: 0x00053724
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x0000C56A File Offset: 0x0000A76A
		public unsafe string optionString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton.NativeFieldInfoPtr_optionString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton.NativeFieldInfoPtr_optionString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0005554C File Offset: 0x0005374C
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x0000C589 File Offset: 0x0000A789
		public unsafe EntityView parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0005557C File Offset: 0x0005377C
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		public unsafe AbilityChoiceConfirmation confirmation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton.NativeFieldInfoPtr_confirmation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityChoiceConfirmation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton.NativeFieldInfoPtr_confirmation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeFieldInfoPtr_choice;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeFieldInfoPtr_optionString;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeFieldInfoPtr_confirmation;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnClick_Public_Void_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_handleSelection_Private_IEnumerator_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_Boolean_ReadOnlyAttributes_0;

		// Token: 0x020003D0 RID: 976
		[ObfuscatedName("worm.match.components.WormAbilityChoiceButton+<handleSelection>d__8")]
		public sealed class _handleSelection_d__8 : Object
		{
			// Token: 0x0600278F RID: 10127 RVA: 0x00090250 File Offset: 0x0008E450
			// Note: this type is marked as 'beforefieldinit'.
			static _handleSelection_d__8()
			{
				Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAbilityChoiceButton>.NativeClassPtr, "<handleSelection>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr);
				WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, "<>1__state");
				WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, "<>2__current");
				WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, "<>4__this");
				WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr__entityID_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, "<entityID>5__2");
				WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr__leafNode_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, "<leafNode>5__3");
				WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr__confirmOrDenyPrompt_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, "<confirmOrDenyPrompt>5__4");
				WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, 100666063);
				WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, 100666064);
				WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, 100666065);
				WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, 100666066);
				WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, 100666067);
				WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr, 100666068);
			}

			// Token: 0x06002790 RID: 10128 RVA: 0x0009036C File Offset: 0x0008E56C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _handleSelection_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityChoiceButton._handleSelection_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002791 RID: 10129 RVA: 0x000903B4 File Offset: 0x0008E5B4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002792 RID: 10130 RVA: 0x000903E8 File Offset: 0x0008E5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713685, XrefRangeEnd = 713708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B10 RID: 2832
			// (get) Token: 0x06002793 RID: 10131 RVA: 0x00090424 File Offset: 0x0008E624
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002794 RID: 10132 RVA: 0x00090464 File Offset: 0x0008E664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713708, XrefRangeEnd = 713713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B11 RID: 2833
			// (get) Token: 0x06002795 RID: 10133 RVA: 0x00090498 File Offset: 0x0008E698
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityChoiceButton._handleSelection_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002796 RID: 10134 RVA: 0x00015BD9 File Offset: 0x00013DD9
			public _handleSelection_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B0A RID: 2826
			// (get) Token: 0x06002797 RID: 10135 RVA: 0x000904D8 File Offset: 0x0008E6D8
			// (set) Token: 0x06002798 RID: 10136 RVA: 0x00015BE2 File Offset: 0x00013DE2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B0B RID: 2827
			// (get) Token: 0x06002799 RID: 10137 RVA: 0x00090500 File Offset: 0x0008E700
			// (set) Token: 0x0600279A RID: 10138 RVA: 0x00015BFD File Offset: 0x00013DFD
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0C RID: 2828
			// (get) Token: 0x0600279B RID: 10139 RVA: 0x00090530 File Offset: 0x0008E730
			// (set) Token: 0x0600279C RID: 10140 RVA: 0x00015C1C File Offset: 0x00013E1C
			public unsafe WormAbilityChoiceButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityChoiceButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0D RID: 2829
			// (get) Token: 0x0600279D RID: 10141 RVA: 0x00090560 File Offset: 0x0008E760
			// (set) Token: 0x0600279E RID: 10142 RVA: 0x00015C3B File Offset: 0x00013E3B
			public unsafe EntityID _entityID_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr__entityID_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr__entityID_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x0600279F RID: 10143 RVA: 0x00090590 File Offset: 0x0008E790
			// (set) Token: 0x060027A0 RID: 10144 RVA: 0x00015C5A File Offset: 0x00013E5A
			public unsafe ISelectionNode _leafNode_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr__leafNode_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr__leafNode_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0F RID: 2831
			// (get) Token: 0x060027A1 RID: 10145 RVA: 0x000905C0 File Offset: 0x0008E7C0
			// (set) Token: 0x060027A2 RID: 10146 RVA: 0x00015C79 File Offset: 0x00013E79
			public unsafe ConfirmOrDenyPrompt _confirmOrDenyPrompt_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr__confirmOrDenyPrompt_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityChoiceButton._handleSelection_d__8.NativeFieldInfoPtr__confirmOrDenyPrompt_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016CA RID: 5834
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016CB RID: 5835
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016CC RID: 5836
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016CD RID: 5837
			private static readonly IntPtr NativeFieldInfoPtr__entityID_5__2;

			// Token: 0x040016CE RID: 5838
			private static readonly IntPtr NativeFieldInfoPtr__leafNode_5__3;

			// Token: 0x040016CF RID: 5839
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDenyPrompt_5__4;

			// Token: 0x040016D0 RID: 5840
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016D1 RID: 5841
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016D2 RID: 5842
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016D3 RID: 5843
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016D4 RID: 5844
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016D5 RID: 5845
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
