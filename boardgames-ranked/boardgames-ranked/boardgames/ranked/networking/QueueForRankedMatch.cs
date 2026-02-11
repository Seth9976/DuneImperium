using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.ranked.networking
{
	// Token: 0x0200000B RID: 11
	public class QueueForRankedMatch : NetworkMessageEvent
	{
		// Token: 0x06000036 RID: 54 RVA: 0x0000421C File Offset: 0x0000241C
		// Note: this type is marked as 'beforefieldinit'.
		static QueueForRankedMatch()
		{
			Il2CppClassPointerStore<QueueForRankedMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking", "QueueForRankedMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueueForRankedMatch>.NativeClassPtr);
			QueueForRankedMatch.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueForRankedMatch>.NativeClassPtr, "Metadata");
			QueueForRankedMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueForRankedMatch>.NativeClassPtr, 100663317);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004274 File Offset: 0x00002474
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueueForRankedMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueueForRankedMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueForRankedMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000223A File Offset: 0x0000043A
		public QueueForRankedMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000042B0 File Offset: 0x000024B0
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002243 File Offset: 0x00000443
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueForRankedMatch.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueForRankedMatch.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
