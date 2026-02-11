using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus.match.messages.outgoing
{
	// Token: 0x020000E8 RID: 232
	public class RequestAILogging : Object
	{
		// Token: 0x06000B53 RID: 2899 RVA: 0x000353F8 File Offset: 0x000335F8
		// Note: this type is marked as 'beforefieldinit'.
		static RequestAILogging()
		{
			Il2CppClassPointerStore<RequestAILogging>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.match.messages.outgoing", "RequestAILogging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestAILogging>.NativeClassPtr);
			RequestAILogging.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestAILogging>.NativeClassPtr, "GameID");
			RequestAILogging.NativeMethodInfoPtr__ctor_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestAILogging>.NativeClassPtr, 100665111);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00035450 File Offset: 0x00033650
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestAILogging(GameID gameID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestAILogging>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestAILogging.NativeMethodInfoPtr__ctor_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00007288 File Offset: 0x00005488
		public RequestAILogging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0003549C File Offset: 0x0003369C
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00007291 File Offset: 0x00005491
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestAILogging.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestAILogging.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_0;
	}
}
