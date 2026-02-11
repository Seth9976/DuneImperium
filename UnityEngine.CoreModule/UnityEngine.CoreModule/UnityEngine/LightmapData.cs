using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000097 RID: 151
	public sealed class LightmapData : Object
	{
		// Token: 0x06000956 RID: 2390 RVA: 0x00034538 File Offset: 0x00032738
		// Note: this type is marked as 'beforefieldinit'.
		static LightmapData()
		{
			Il2CppClassPointerStore<LightmapData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightmapData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapData>.NativeClassPtr);
			LightmapData.NativeFieldInfoPtr_m_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, "m_Light");
			LightmapData.NativeFieldInfoPtr_m_Dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, "m_Dir");
			LightmapData.NativeFieldInfoPtr_m_ShadowMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, "m_ShadowMask");
			LightmapData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, 100664358);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000345B8 File Offset: 0x000327B8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightmapData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightmapData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0000589F File Offset: 0x00003A9F
		public LightmapData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x000345F4 File Offset: 0x000327F4
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x000058A8 File Offset: 0x00003AA8
		public unsafe Texture2D m_Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00034624 File Offset: 0x00032824
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x000058C7 File Offset: 0x00003AC7
		public unsafe Texture2D m_Dir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Dir);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Dir), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00034654 File Offset: 0x00032854
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x000058E6 File Offset: 0x00003AE6
		public unsafe Texture2D m_ShadowMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_ShadowMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_ShadowMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00034684 File Offset: 0x00032884
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00005905 File Offset: 0x00003B05
		public Texture2D lightmapLight
		{
			get
			{
				return this.m_Light;
			}
			set
			{
				this.m_Light = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0003469C File Offset: 0x0003289C
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x0000590F File Offset: 0x00003B0F
		public Texture2D lightmapColor
		{
			get
			{
				return this.m_Light;
			}
			set
			{
				this.m_Light = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x000346B4 File Offset: 0x000328B4
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00005919 File Offset: 0x00003B19
		public Texture2D lightmapDir
		{
			get
			{
				return this.m_Dir;
			}
			set
			{
				this.m_Dir = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x000346CC File Offset: 0x000328CC
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00005923 File Offset: 0x00003B23
		public Texture2D shadowMask
		{
			get
			{
				return this.m_ShadowMask;
			}
			set
			{
				this.m_ShadowMask = value;
			}
		}

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_m_Light;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_m_Dir;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowMask;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
