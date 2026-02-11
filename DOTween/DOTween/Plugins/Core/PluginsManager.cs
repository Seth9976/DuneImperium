using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x0200003F RID: 63
	public static class PluginsManager : Object
	{
		// Token: 0x060003A0 RID: 928 RVA: 0x00017A68 File Offset: 0x00015C68
		// Note: this type is marked as 'beforefieldinit'.
		static PluginsManager()
		{
			Il2CppClassPointerStore<PluginsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core", "PluginsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr);
			PluginsManager.NativeFieldInfoPtr__floatPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_floatPlugin");
			PluginsManager.NativeFieldInfoPtr__doublePlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_doublePlugin");
			PluginsManager.NativeFieldInfoPtr__intPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_intPlugin");
			PluginsManager.NativeFieldInfoPtr__uintPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_uintPlugin");
			PluginsManager.NativeFieldInfoPtr__longPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_longPlugin");
			PluginsManager.NativeFieldInfoPtr__ulongPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_ulongPlugin");
			PluginsManager.NativeFieldInfoPtr__vector2Plugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_vector2Plugin");
			PluginsManager.NativeFieldInfoPtr__vector3Plugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_vector3Plugin");
			PluginsManager.NativeFieldInfoPtr__vector4Plugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_vector4Plugin");
			PluginsManager.NativeFieldInfoPtr__quaternionPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_quaternionPlugin");
			PluginsManager.NativeFieldInfoPtr__colorPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_colorPlugin");
			PluginsManager.NativeFieldInfoPtr__rectPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_rectPlugin");
			PluginsManager.NativeFieldInfoPtr__rectOffsetPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_rectOffsetPlugin");
			PluginsManager.NativeFieldInfoPtr__stringPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_stringPlugin");
			PluginsManager.NativeFieldInfoPtr__vector3ArrayPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_vector3ArrayPlugin");
			PluginsManager.NativeFieldInfoPtr__color2Plugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_color2Plugin");
			PluginsManager.NativeFieldInfoPtr__MaxCustomPlugins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_MaxCustomPlugins");
			PluginsManager.NativeFieldInfoPtr__customPlugins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_customPlugins");
			PluginsManager.NativeMethodInfoPtr_GetDefaultPlugin_Internal_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, 100664110);
			PluginsManager.NativeMethodInfoPtr_GetCustomPlugin_Public_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, 100664111);
			PluginsManager.NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, 100664112);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00017C3C File Offset: 0x00015E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132776, RefRangeEnd = 1132777, XrefRangeStart = 1132519, XrefRangeEnd = 1132776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>() where TPlugOptions : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginsManager.MethodInfoStoreGeneric_GetDefaultPlugin_Internal_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ABSTweenPlugin<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00017C70 File Offset: 0x00015E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132792, RefRangeEnd = 1132793, XrefRangeStart = 1132777, XrefRangeEnd = 1132792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>() where TPlugin : new() where TPlugOptions : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginsManager.MethodInfoStoreGeneric_GetCustomPlugin_Public_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<TPlugin, T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ABSTweenPlugin<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00017CA4 File Offset: 0x00015EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132843, RefRangeEnd = 1132844, XrefRangeStart = 1132793, XrefRangeEnd = 1132843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PurgeAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginsManager.NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000030FD File Offset: 0x000012FD
		public PluginsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00017CCC File Offset: 0x00015ECC
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00003106 File Offset: 0x00001306
		public unsafe static ITweenPlugin _floatPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__floatPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__floatPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00017CF4 File Offset: 0x00015EF4
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x00003118 File Offset: 0x00001318
		public unsafe static ITweenPlugin _doublePlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__doublePlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__doublePlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00017D1C File Offset: 0x00015F1C
		// (set) Token: 0x060003AA RID: 938 RVA: 0x0000312A File Offset: 0x0000132A
		public unsafe static ITweenPlugin _intPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__intPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__intPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00017D44 File Offset: 0x00015F44
		// (set) Token: 0x060003AC RID: 940 RVA: 0x0000313C File Offset: 0x0000133C
		public unsafe static ITweenPlugin _uintPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__uintPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__uintPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00017D6C File Offset: 0x00015F6C
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000314E File Offset: 0x0000134E
		public unsafe static ITweenPlugin _longPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__longPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__longPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00017D94 File Offset: 0x00015F94
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003160 File Offset: 0x00001360
		public unsafe static ITweenPlugin _ulongPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__ulongPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__ulongPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00017DBC File Offset: 0x00015FBC
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003172 File Offset: 0x00001372
		public unsafe static ITweenPlugin _vector2Plugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__vector2Plugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__vector2Plugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00017DE4 File Offset: 0x00015FE4
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00003184 File Offset: 0x00001384
		public unsafe static ITweenPlugin _vector3Plugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__vector3Plugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__vector3Plugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00017E0C File Offset: 0x0001600C
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00003196 File Offset: 0x00001396
		public unsafe static ITweenPlugin _vector4Plugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__vector4Plugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__vector4Plugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00017E34 File Offset: 0x00016034
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x000031A8 File Offset: 0x000013A8
		public unsafe static ITweenPlugin _quaternionPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__quaternionPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__quaternionPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00017E5C File Offset: 0x0001605C
		// (set) Token: 0x060003BA RID: 954 RVA: 0x000031BA File Offset: 0x000013BA
		public unsafe static ITweenPlugin _colorPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__colorPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__colorPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00017E84 File Offset: 0x00016084
		// (set) Token: 0x060003BC RID: 956 RVA: 0x000031CC File Offset: 0x000013CC
		public unsafe static ITweenPlugin _rectPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__rectPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__rectPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00017EAC File Offset: 0x000160AC
		// (set) Token: 0x060003BE RID: 958 RVA: 0x000031DE File Offset: 0x000013DE
		public unsafe static ITweenPlugin _rectOffsetPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__rectOffsetPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__rectOffsetPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00017ED4 File Offset: 0x000160D4
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x000031F0 File Offset: 0x000013F0
		public unsafe static ITweenPlugin _stringPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__stringPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__stringPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00017EFC File Offset: 0x000160FC
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00003202 File Offset: 0x00001402
		public unsafe static ITweenPlugin _vector3ArrayPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__vector3ArrayPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__vector3ArrayPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00017F24 File Offset: 0x00016124
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003214 File Offset: 0x00001414
		public unsafe static ITweenPlugin _color2Plugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__color2Plugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__color2Plugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00017F4C File Offset: 0x0001614C
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00003226 File Offset: 0x00001426
		public unsafe static int _MaxCustomPlugins
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__MaxCustomPlugins, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__MaxCustomPlugins, (void*)(&value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00017F68 File Offset: 0x00016168
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00003234 File Offset: 0x00001434
		public unsafe static Dictionary<Type, ITweenPlugin> _customPlugins
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__customPlugins, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, ITweenPlugin>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__customPlugins, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr__floatPlugin;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr__doublePlugin;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr__intPlugin;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr__uintPlugin;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeFieldInfoPtr__longPlugin;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr__ulongPlugin;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr__vector2Plugin;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr__vector3Plugin;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr__vector4Plugin;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr__quaternionPlugin;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr__colorPlugin;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr__rectPlugin;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr__rectOffsetPlugin;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr__stringPlugin;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr__vector3ArrayPlugin;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr__color2Plugin;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr__MaxCustomPlugins;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr__customPlugins;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultPlugin_Internal_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomPlugin_Public_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0;

		// Token: 0x020000E4 RID: 228
		private sealed class MethodInfoStoreGeneric_GetDefaultPlugin_Internal_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000607 RID: 1543
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PluginsManager.NativeMethodInfoPtr_GetDefaultPlugin_Internal_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<PluginsManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000E5 RID: 229
		private sealed class MethodInfoStoreGeneric_GetCustomPlugin_Public_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<TPlugin, T1, T2, TPlugOptions>
		{
			// Token: 0x04000608 RID: 1544
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PluginsManager.NativeMethodInfoPtr_GetCustomPlugin_Public_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<PluginsManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugin>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}
	}
}
