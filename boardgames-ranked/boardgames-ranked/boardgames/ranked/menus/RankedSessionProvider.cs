using System;
using boardgames.menus;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.ranked.menus
{
	// Token: 0x0200002E RID: 46
	public class RankedSessionProvider : OnlinePlaySessionProvider
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x000080EC File Offset: 0x000062EC
		// Note: this type is marked as 'beforefieldinit'.
		static RankedSessionProvider()
		{
			Il2CppClassPointerStore<RankedSessionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedSessionProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedSessionProvider>.NativeClassPtr);
			RankedSessionProvider.NativeMethodInfoPtr_get_AlwaysLogMessages_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedSessionProvider>.NativeClassPtr, 100663442);
			RankedSessionProvider.NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedSessionProvider>.NativeClassPtr, 100663443);
			RankedSessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedSessionProvider>.NativeClassPtr, 100663444);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00008158 File Offset: 0x00006358
		public unsafe override bool AlwaysLogMessages
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedSessionProvider.NativeMethodInfoPtr_get_AlwaysLogMessages_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000081A0 File Offset: 0x000063A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225845, XrefRangeEnd = 1225867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NetworkMessageEvent RegisterUser(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedSessionProvider.NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000081FC File Offset: 0x000063FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedSessionProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedSessionProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedSessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002F9A File Offset: 0x0000119A
		public RankedSessionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_get_AlwaysLogMessages_Protected_Virtual_get_Boolean_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
