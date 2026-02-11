using System;
using Canis;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000280 RID: 640
	public class LoseUnits : RetreatUnits
	{
		// Token: 0x06001AE0 RID: 6880 RVA: 0x000C151C File Offset: 0x000BF71C
		// Note: this type is marked as 'beforefieldinit'.
		static LoseUnits()
		{
			Il2CppClassPointerStore<LoseUnits>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "LoseUnits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoseUnits>.NativeClassPtr);
			LoseUnits.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnits>.NativeClassPtr, 100668532);
			LoseUnits.NativeMethodInfoPtr_GetPlayArea_Protected_Virtual_WormPlayArea_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnits>.NativeClassPtr, 100668533);
			LoseUnits.NativeMethodInfoPtr_get_GetLogToken_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnits>.NativeClassPtr, 100668534);
			LoseUnits.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnits>.NativeClassPtr, 100668535);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x000C159C File Offset: 0x000BF79C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 144528, RefRangeEnd = 144532, XrefRangeStart = 144527, XrefRangeEnd = 144528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoseUnits(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoseUnits>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnits.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x000C15E8 File Offset: 0x000BF7E8
		[CallerCount(0)]
		public unsafe override WormPlayArea GetPlayArea(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoseUnits.NativeMethodInfoPtr_GetPlayArea_Protected_Virtual_WormPlayArea_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x000C1644 File Offset: 0x000BF844
		public unsafe override string GetLogToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144532, XrefRangeEnd = 144534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoseUnits.NativeMethodInfoPtr_get_GetLogToken_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x000C1688 File Offset: 0x000BF888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144534, XrefRangeEnd = 144538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoseUnits.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0000B898 File Offset: 0x00009A98
		public LoseUnits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayArea_Protected_Virtual_WormPlayArea_WormPlayer_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_get_GetLogToken_Protected_Virtual_get_String_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;
	}
}
