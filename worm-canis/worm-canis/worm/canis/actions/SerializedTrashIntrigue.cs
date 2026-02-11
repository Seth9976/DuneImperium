using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x020002A2 RID: 674
	public class SerializedTrashIntrigue : SerializedAction
	{
		// Token: 0x06001C04 RID: 7172 RVA: 0x000C5B9C File Offset: 0x000C3D9C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedTrashIntrigue()
		{
			Il2CppClassPointerStore<SerializedTrashIntrigue>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedTrashIntrigue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedTrashIntrigue>.NativeClassPtr);
			SerializedTrashIntrigue.NativeFieldInfoPtr_LogMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTrashIntrigue>.NativeClassPtr, "LogMode");
			SerializedTrashIntrigue.NativeFieldInfoPtr_ShowSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTrashIntrigue>.NativeClassPtr, "ShowSequence");
			SerializedTrashIntrigue.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTrashIntrigue>.NativeClassPtr, 100668975);
			SerializedTrashIntrigue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTrashIntrigue>.NativeClassPtr, 100668976);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000C5C1C File Offset: 0x000C3E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149194, XrefRangeEnd = 149198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedTrashIntrigue.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x000C5C78 File Offset: 0x000C3E78
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedTrashIntrigue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedTrashIntrigue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedTrashIntrigue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0000BEDA File Offset: 0x0000A0DA
		public SerializedTrashIntrigue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000C5CB4 File Offset: 0x000C3EB4
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x0000BEE3 File Offset: 0x0000A0E3
		public unsafe ActionLogModes LogMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashIntrigue.NativeFieldInfoPtr_LogMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashIntrigue.NativeFieldInfoPtr_LogMode)) = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000C5CDC File Offset: 0x000C3EDC
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x0000BEFE File Offset: 0x0000A0FE
		public unsafe bool ShowSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashIntrigue.NativeFieldInfoPtr_ShowSequence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashIntrigue.NativeFieldInfoPtr_ShowSequence)) = value;
			}
		}

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeFieldInfoPtr_LogMode;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeFieldInfoPtr_ShowSequence;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
