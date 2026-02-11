using System;
using Canis;
using Canis.entities.ai;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.selection.messages;
using worm.canis.entities;

namespace worm.canis.ai
{
	// Token: 0x02000216 RID: 534
	public class WormAIChoiceContext : AIChoiceContext
	{
		// Token: 0x0600173A RID: 5946 RVA: 0x000B24BC File Offset: 0x000B06BC
		// Note: this type is marked as 'beforefieldinit'.
		static WormAIChoiceContext()
		{
			Il2CppClassPointerStore<WormAIChoiceContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai", "WormAIChoiceContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIChoiceContext>.NativeClassPtr);
			WormAIChoiceContext.NativeFieldInfoPtr_WormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceContext>.NativeClassPtr, "WormMatch");
			WormAIChoiceContext.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceContext>.NativeClassPtr, "Player");
			WormAIChoiceContext.NativeMethodInfoPtr_get_AIProfile_Public_get_WormAIProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceContext>.NativeClassPtr, 100667070);
			WormAIChoiceContext.NativeMethodInfoPtr__ctor_Public_Void_Match_SelectionMessage_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceContext>.NativeClassPtr, 100667071);
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x000B253C File Offset: 0x000B073C
		public unsafe WormAIProfile AIProfile
		{
			[CallerCount(408)]
			[CachedScanResults(RefRangeStart = 122525, RefRangeEnd = 122933, XrefRangeStart = 122525, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceContext.NativeMethodInfoPtr_get_AIProfile_Public_get_WormAIProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr3) : null;
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x000B257C File Offset: 0x000B077C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 122942, RefRangeEnd = 122948, XrefRangeStart = 122933, XrefRangeEnd = 122942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAIChoiceContext(Match m, SelectionMessage s, WormPlayer player)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIChoiceContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceContext.NativeMethodInfoPtr__ctor_Public_Void_Match_SelectionMessage_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0000A4D8 File Offset: 0x000086D8
		public WormAIChoiceContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x000B25EC File Offset: 0x000B07EC
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x0000A4E1 File Offset: 0x000086E1
		public unsafe WormMatch WormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceContext.NativeFieldInfoPtr_WormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceContext.NativeFieldInfoPtr_WormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x000B261C File Offset: 0x000B081C
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x0000A500 File Offset: 0x00008700
		public unsafe WormPlayer Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceContext.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceContext.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeFieldInfoPtr_WormMatch;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_get_AIProfile_Public_get_WormAIProfile_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_SelectionMessage_WormPlayer_0;
	}
}
