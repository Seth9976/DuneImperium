using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200028D RID: 653
	public class SerializedTrashTile : SerializedAction
	{
		// Token: 0x06001B4E RID: 6990 RVA: 0x000C3084 File Offset: 0x000C1284
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedTrashTile()
		{
			Il2CppClassPointerStore<SerializedTrashTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedTrashTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedTrashTile>.NativeClassPtr);
			SerializedTrashTile.NativeFieldInfoPtr_LogMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTrashTile>.NativeClassPtr, "LogMode");
			SerializedTrashTile.NativeFieldInfoPtr_ShowSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTrashTile>.NativeClassPtr, "ShowSequence");
			SerializedTrashTile.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTrashTile>.NativeClassPtr, 100668707);
			SerializedTrashTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTrashTile>.NativeClassPtr, 100668708);
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x000C3104 File Offset: 0x000C1304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146168, XrefRangeEnd = 146172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedTrashTile.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x000C3160 File Offset: 0x000C1360
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedTrashTile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedTrashTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedTrashTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0000BAAE File Offset: 0x00009CAE
		public SerializedTrashTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x000C319C File Offset: 0x000C139C
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0000BAB7 File Offset: 0x00009CB7
		public unsafe ActionLogModes LogMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashTile.NativeFieldInfoPtr_LogMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashTile.NativeFieldInfoPtr_LogMode)) = value;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x000C31C4 File Offset: 0x000C13C4
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0000BAD2 File Offset: 0x00009CD2
		public unsafe bool ShowSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashTile.NativeFieldInfoPtr_ShowSequence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTrashTile.NativeFieldInfoPtr_ShowSequence)) = value;
			}
		}

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeFieldInfoPtr_LogMode;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeFieldInfoPtr_ShowSequence;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
