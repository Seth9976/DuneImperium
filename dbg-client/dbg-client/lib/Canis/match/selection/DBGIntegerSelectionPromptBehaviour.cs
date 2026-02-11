using System;
using boardgames.match.selection;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.UI;

namespace lib.canis.match.selection
{
	// Token: 0x02000023 RID: 35
	public class DBGIntegerSelectionPromptBehaviour : PromptBehaviour<DBGSelectIntegerPrompt>
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00021A40 File Offset: 0x0001FC40
		// Note: this type is marked as 'beforefieldinit'.
		static DBGIntegerSelectionPromptBehaviour()
		{
			Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.match.selection", "DBGIntegerSelectionPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr);
			DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_selectedIntegerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr, "selectedIntegerText");
			DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_incrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr, "incrementButton");
			DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_reduceButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr, "reduceButton");
			DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_selectedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr, "selectedValue");
			DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr, "selectionResponder");
			DBGIntegerSelectionPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr, 100663542);
			DBGIntegerSelectionPromptBehaviour.NativeMethodInfoPtr_Event_Increment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr, 100663543);
			DBGIntegerSelectionPromptBehaviour.NativeMethodInfoPtr_Event_Reduce_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr, 100663544);
			DBGIntegerSelectionPromptBehaviour.NativeMethodInfoPtr_updateButtonStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr, 100663545);
			DBGIntegerSelectionPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr, 100663546);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00021B38 File Offset: 0x0001FD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497407, XrefRangeEnd = 497420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGIntegerSelectionPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00021B74 File Offset: 0x0001FD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497420, XrefRangeEnd = 497422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Increment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGIntegerSelectionPromptBehaviour.NativeMethodInfoPtr_Event_Increment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00021BA8 File Offset: 0x0001FDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497422, XrefRangeEnd = 497424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Reduce()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGIntegerSelectionPromptBehaviour.NativeMethodInfoPtr_Event_Reduce_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00021BDC File Offset: 0x0001FDDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 497432, RefRangeEnd = 497435, XrefRangeStart = 497424, XrefRangeEnd = 497432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateButtonStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGIntegerSelectionPromptBehaviour.NativeMethodInfoPtr_updateButtonStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00021C10 File Offset: 0x0001FE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497435, XrefRangeEnd = 497438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGIntegerSelectionPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGIntegerSelectionPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGIntegerSelectionPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002792 File Offset: 0x00000992
		public DBGIntegerSelectionPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00021C4C File Offset: 0x0001FE4C
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000279B File Offset: 0x0000099B
		public unsafe TMP_Text selectedIntegerText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_selectedIntegerText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_selectedIntegerText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00021C7C File Offset: 0x0001FE7C
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000027BA File Offset: 0x000009BA
		public unsafe Button incrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_incrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_incrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00021CAC File Offset: 0x0001FEAC
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000027D9 File Offset: 0x000009D9
		public unsafe Button reduceButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_reduceButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_reduceButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00021CDC File Offset: 0x0001FEDC
		// (set) Token: 0x0600014D RID: 333 RVA: 0x000027F8 File Offset: 0x000009F8
		public unsafe int selectedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_selectedValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_selectedValue)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00021D04 File Offset: 0x0001FF04
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002813 File Offset: 0x00000A13
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGIntegerSelectionPromptBehaviour.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_selectedIntegerText;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_incrementButton;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_reduceButton;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_selectedValue;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_Event_Increment_Public_Void_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_Event_Reduce_Public_Void_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_updateButtonStates_Private_Void_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
