using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.lobby
{
	// Token: 0x02000098 RID: 152
	public class JoinQueue : NetworkMessageEvent
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x00013924 File Offset: 0x00011B24
		// Note: this type is marked as 'beforefieldinit'.
		static JoinQueue()
		{
			Il2CppClassPointerStore<JoinQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "JoinQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinQueue>.NativeClassPtr);
			JoinQueue.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinQueue>.NativeClassPtr, "Game");
			JoinQueue.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinQueue>.NativeClassPtr, "Metadata");
			JoinQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinQueue>.NativeClassPtr, 100663627);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00013990 File Offset: 0x00011B90
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00005148 File Offset: 0x00003348
		public JoinQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000139CC File Offset: 0x00011BCC
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00005151 File Offset: 0x00003351
		public unsafe string Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinQueue.NativeFieldInfoPtr_Game);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinQueue.NativeFieldInfoPtr_Game), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000139F4 File Offset: 0x00011BF4
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00005170 File Offset: 0x00003370
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinQueue.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinQueue.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
