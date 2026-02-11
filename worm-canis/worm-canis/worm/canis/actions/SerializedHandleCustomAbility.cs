using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000257 RID: 599
	public class SerializedHandleCustomAbility : SerializedAction
	{
		// Token: 0x060019D2 RID: 6610 RVA: 0x000BD4E4 File Offset: 0x000BB6E4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedHandleCustomAbility()
		{
			Il2CppClassPointerStore<SerializedHandleCustomAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedHandleCustomAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedHandleCustomAbility>.NativeClassPtr);
			SerializedHandleCustomAbility.NativeFieldInfoPtr_IsAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedHandleCustomAbility>.NativeClassPtr, "IsAdd");
			SerializedHandleCustomAbility.NativeFieldInfoPtr_SerAbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedHandleCustomAbility>.NativeClassPtr, "SerAbilityID");
			SerializedHandleCustomAbility.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedHandleCustomAbility>.NativeClassPtr, 100668057);
			SerializedHandleCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedHandleCustomAbility>.NativeClassPtr, 100668058);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x000BD564 File Offset: 0x000BB764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138334, XrefRangeEnd = 138338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedHandleCustomAbility.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x000BD5C0 File Offset: 0x000BB7C0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedHandleCustomAbility()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedHandleCustomAbility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedHandleCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0000B1E8 File Offset: 0x000093E8
		public SerializedHandleCustomAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x000BD5FC File Offset: 0x000BB7FC
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x0000B1F1 File Offset: 0x000093F1
		public unsafe bool IsAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedHandleCustomAbility.NativeFieldInfoPtr_IsAdd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedHandleCustomAbility.NativeFieldInfoPtr_IsAdd)) = value;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x000BD624 File Offset: 0x000BB824
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x0000B20C File Offset: 0x0000940C
		public unsafe AbilityID SerAbilityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedHandleCustomAbility.NativeFieldInfoPtr_SerAbilityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedHandleCustomAbility.NativeFieldInfoPtr_SerAbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeFieldInfoPtr_IsAdd;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeFieldInfoPtr_SerAbilityID;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
