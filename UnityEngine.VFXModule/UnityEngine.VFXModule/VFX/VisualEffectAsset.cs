using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.VFX
{
	// Token: 0x0200000B RID: 11
	public class VisualEffectAsset : VisualEffectObject
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00004C2C File Offset: 0x00002E2C
		// Note: this type is marked as 'beforefieldinit'.
		static VisualEffectAsset()
		{
			Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VisualEffectAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr);
			VisualEffectAsset.NativeFieldInfoPtr_PlayEventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, "PlayEventID");
			VisualEffectAsset.NativeFieldInfoPtr_StopEventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, "StopEventID");
			VisualEffectAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663326);
			VisualEffectAsset.GetTextureDimensionDelegateField = IL2CPP.ResolveICall<VisualEffectAsset.GetTextureDimensionDelegate>("UnityEngine.VFX.VisualEffectAsset::GetTextureDimension");
			VisualEffectAsset.GetEventsDelegateField = IL2CPP.ResolveICall<VisualEffectAsset.GetEventsDelegate>("UnityEngine.VFX.VisualEffectAsset::GetEvents");
			VisualEffectAsset.HasSystemDelegateField = IL2CPP.ResolveICall<VisualEffectAsset.HasSystemDelegate>("UnityEngine.VFX.VisualEffectAsset::HasSystem");
			VisualEffectAsset.GetSystemNamesDelegateField = IL2CPP.ResolveICall<VisualEffectAsset.GetSystemNamesDelegate>("UnityEngine.VFX.VisualEffectAsset::GetSystemNames");
			VisualEffectAsset.GetParticleSystemNamesDelegateField = IL2CPP.ResolveICall<VisualEffectAsset.GetParticleSystemNamesDelegate>("UnityEngine.VFX.VisualEffectAsset::GetParticleSystemNames");
			VisualEffectAsset.GetOutputEventNamesDelegateField = IL2CPP.ResolveICall<VisualEffectAsset.GetOutputEventNamesDelegate>("UnityEngine.VFX.VisualEffectAsset::GetOutputEventNames");
			VisualEffectAsset.GetSpawnSystemNamesDelegateField = IL2CPP.ResolveICall<VisualEffectAsset.GetSpawnSystemNamesDelegate>("UnityEngine.VFX.VisualEffectAsset::GetSpawnSystemNames");
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004D04 File Offset: 0x00002F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualEffectAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffectAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002910 File Offset: 0x00000B10
		public VisualEffectAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00004D40 File Offset: 0x00002F40
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002919 File Offset: 0x00000B19
		public unsafe static int PlayEventID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(VisualEffectAsset.NativeFieldInfoPtr_PlayEventID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualEffectAsset.NativeFieldInfoPtr_PlayEventID, (void*)(&value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00004D5C File Offset: 0x00002F5C
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002927 File Offset: 0x00000B27
		public unsafe static int StopEventID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(VisualEffectAsset.NativeFieldInfoPtr_StopEventID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualEffectAsset.NativeFieldInfoPtr_StopEventID, (void*)(&value));
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002935 File Offset: 0x00000B35
		public TextureDimension GetTextureDimension(int nameID)
		{
			return VisualEffectAsset.GetTextureDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002948 File Offset: 0x00000B48
		public void GetEvents(List<string> names)
		{
			VisualEffectAsset.GetEventsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002960 File Offset: 0x00000B60
		public bool HasSystem(int nameID)
		{
			return VisualEffectAsset.HasSystemDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002973 File Offset: 0x00000B73
		public void GetSystemNames(List<string> names)
		{
			VisualEffectAsset.GetSystemNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000298B File Offset: 0x00000B8B
		public void GetParticleSystemNames(List<string> names)
		{
			VisualEffectAsset.GetParticleSystemNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000029A3 File Offset: 0x00000BA3
		public void GetOutputEventNames(List<string> names)
		{
			VisualEffectAsset.GetOutputEventNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000029BB File Offset: 0x00000BBB
		public void GetSpawnSystemNames(List<string> names)
		{
			VisualEffectAsset.GetSpawnSystemNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004D78 File Offset: 0x00002F78
		public TextureDimension GetTextureDimension(string name)
		{
			return this.GetTextureDimension(Shader.PropertyToID(name));
		}

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_PlayEventID;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_StopEventID;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000088 RID: 136
		public const string PlayEventName = "OnPlay";

		// Token: 0x04000089 RID: 137
		public const string StopEventName = "OnStop";

		// Token: 0x0400008A RID: 138
		private static readonly VisualEffectAsset.GetTextureDimensionDelegate GetTextureDimensionDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly VisualEffectAsset.GetEventsDelegate GetEventsDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly VisualEffectAsset.HasSystemDelegate HasSystemDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly VisualEffectAsset.GetSystemNamesDelegate GetSystemNamesDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly VisualEffectAsset.GetParticleSystemNamesDelegate GetParticleSystemNamesDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly VisualEffectAsset.GetOutputEventNamesDelegate GetOutputEventNamesDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly VisualEffectAsset.GetSpawnSystemNamesDelegate GetSpawnSystemNamesDelegateField;

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x06000231 RID: 561
		private delegate TextureDimension GetTextureDimensionDelegate(IntPtr @this, int nameID);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000233 RID: 563
		private delegate void GetEventsDelegate(IntPtr @this, IntPtr names);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000235 RID: 565
		private delegate bool HasSystemDelegate(IntPtr @this, int nameID);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000237 RID: 567
		private delegate void GetSystemNamesDelegate(IntPtr @this, IntPtr names);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000239 RID: 569
		private delegate void GetParticleSystemNamesDelegate(IntPtr @this, IntPtr names);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x0600023B RID: 571
		private delegate void GetOutputEventNamesDelegate(IntPtr @this, IntPtr names);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x0600023D RID: 573
		private delegate void GetSpawnSystemNamesDelegate(IntPtr @this, IntPtr names);
	}
}
