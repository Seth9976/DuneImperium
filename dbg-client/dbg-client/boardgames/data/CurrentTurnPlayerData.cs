using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x02000183 RID: 387
	public class CurrentTurnPlayerData : VersionedDataComponent
	{
		// Token: 0x060010E8 RID: 4328 RVA: 0x00052F2C File Offset: 0x0005112C
		// Note: this type is marked as 'beforefieldinit'.
		static CurrentTurnPlayerData()
		{
			Il2CppClassPointerStore<CurrentTurnPlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "CurrentTurnPlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurrentTurnPlayerData>.NativeClassPtr);
			CurrentTurnPlayerData.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentTurnPlayerData>.NativeClassPtr, "Current");
			CurrentTurnPlayerData.NativeFieldInfoPtr_IsLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentTurnPlayerData>.NativeClassPtr, "IsLocalPlayer");
			CurrentTurnPlayerData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentTurnPlayerData>.NativeClassPtr, 100665661);
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00052F98 File Offset: 0x00051198
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 514337, RefRangeEnd = 514341, XrefRangeStart = 514336, XrefRangeEnd = 514337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurrentTurnPlayerData(bool current, bool isLocal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurrentTurnPlayerData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentTurnPlayerData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0000A267 File Offset: 0x00008467
		public CurrentTurnPlayerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00052FF0 File Offset: 0x000511F0
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x0000A270 File Offset: 0x00008470
		public unsafe bool Current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentTurnPlayerData.NativeFieldInfoPtr_Current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentTurnPlayerData.NativeFieldInfoPtr_Current)) = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00053018 File Offset: 0x00051218
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x0000A28B File Offset: 0x0000848B
		public unsafe bool IsLocalPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentTurnPlayerData.NativeFieldInfoPtr_IsLocalPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentTurnPlayerData.NativeFieldInfoPtr_IsLocalPlayer)) = value;
			}
		}

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr_Current;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr_IsLocalPlayer;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;
	}
}
