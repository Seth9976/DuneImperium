using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001C5 RID: 453
	public class AddFriendPromptBehaviour : PromptBehaviour<AddFriendPrompt>
	{
		// Token: 0x0600145F RID: 5215 RVA: 0x0005F568 File Offset: 0x0005D768
		// Note: this type is marked as 'beforefieldinit'.
		static AddFriendPromptBehaviour()
		{
			Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "AddFriendPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr);
			AddFriendPromptBehaviour.NativeFieldInfoPtr_emailOrScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr, "emailOrScreenName");
			AddFriendPromptBehaviour.NativeFieldInfoPtr_invalidInputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr, "invalidInputIcon");
			AddFriendPromptBehaviour.NativeFieldInfoPtr_addFriendButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr, "addFriendButton");
			AddFriendPromptBehaviour.NativeMethodInfoPtr_get_validEmail_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr, 100666277);
			AddFriendPromptBehaviour.NativeMethodInfoPtr_get_validScreenName_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr, 100666278);
			AddFriendPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr, 100666279);
			AddFriendPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr, 100666280);
			AddFriendPromptBehaviour.NativeMethodInfoPtr_Event_SendInvite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr, 100666281);
			AddFriendPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr, 100666282);
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0005F64C File Offset: 0x0005D84C
		public unsafe bool validEmail
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520327, XrefRangeEnd = 520333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendPromptBehaviour.NativeMethodInfoPtr_get_validEmail_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0005F688 File Offset: 0x0005D888
		public unsafe bool validScreenName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520333, XrefRangeEnd = 520339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendPromptBehaviour.NativeMethodInfoPtr_get_validScreenName_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0005F6C4 File Offset: 0x0005D8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520339, XrefRangeEnd = 520343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddFriendPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0005F700 File Offset: 0x0005D900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520343, XrefRangeEnd = 520358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0005F734 File Offset: 0x0005D934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520358, XrefRangeEnd = 520362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SendInvite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendPromptBehaviour.NativeMethodInfoPtr_Event_SendInvite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0005F768 File Offset: 0x0005D968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520362, XrefRangeEnd = 520365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddFriendPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddFriendPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0000B93F File Offset: 0x00009B3F
		public AddFriendPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0005F7A4 File Offset: 0x0005D9A4
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x0000B948 File Offset: 0x00009B48
		public unsafe TMP_InputField emailOrScreenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendPromptBehaviour.NativeFieldInfoPtr_emailOrScreenName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendPromptBehaviour.NativeFieldInfoPtr_emailOrScreenName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0005F7D4 File Offset: 0x0005D9D4
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x0000B967 File Offset: 0x00009B67
		public unsafe GameObject invalidInputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendPromptBehaviour.NativeFieldInfoPtr_invalidInputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendPromptBehaviour.NativeFieldInfoPtr_invalidInputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0005F804 File Offset: 0x0005DA04
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x0000B986 File Offset: 0x00009B86
		public unsafe Button addFriendButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendPromptBehaviour.NativeFieldInfoPtr_addFriendButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendPromptBehaviour.NativeFieldInfoPtr_addFriendButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeFieldInfoPtr_emailOrScreenName;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeFieldInfoPtr_invalidInputIcon;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeFieldInfoPtr_addFriendButton;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_get_validEmail_Private_get_Boolean_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_get_validScreenName_Private_get_Boolean_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_Event_SendInvite_Public_Void_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
