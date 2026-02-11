using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000007 RID: 7
	public class YogaConfig : Object
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0001CEC4 File Offset: 0x0001B0C4
		// Note: this type is marked as 'beforefieldinit'.
		static YogaConfig()
		{
			Il2CppClassPointerStore<YogaConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.Yoga", "YogaConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr);
			YogaConfig.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, "Default");
			YogaConfig.NativeFieldInfoPtr__ygConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, "_ygConfig");
			YogaConfig.NativeFieldInfoPtr__logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, "_logger");
			YogaConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, 100663305);
			YogaConfig.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, 100663306);
			YogaConfig.NativeMethodInfoPtr_get_Handle_Internal_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, 100663307);
			YogaConfig.NativeMethodInfoPtr_get_UseWebDefaults_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, 100663308);
			YogaConfig.NativeMethodInfoPtr_set_UseWebDefaults_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, 100663309);
			YogaConfig.NativeMethodInfoPtr_set_PointScaleFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, 100663310);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282413, RefRangeEnd = 282415, XrefRangeStart = 282408, XrefRangeEnd = 282413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YogaConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0001CFE4 File Offset: 0x0001B1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282415, XrefRangeEnd = 282426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), YogaConfig.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0001D020 File Offset: 0x0001B220
		public unsafe IntPtr Handle
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaConfig.NativeMethodInfoPtr_get_Handle_Internal_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0001D05C File Offset: 0x0001B25C
		// (set) Token: 0x0600001E RID: 30 RVA: 0x0001D098 File Offset: 0x0001B298
		public unsafe bool UseWebDefaults
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282597, RefRangeEnd = 282599, XrefRangeStart = 282595, XrefRangeEnd = 282597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaConfig.NativeMethodInfoPtr_get_UseWebDefaults_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282601, RefRangeEnd = 282603, XrefRangeStart = 282599, XrefRangeEnd = 282601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaConfig.NativeMethodInfoPtr_set_UseWebDefaults_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0001D1D0 File Offset: 0x0001B3D0
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0001D0D8 File Offset: 0x0001B2D8
		public unsafe float PointScaleFactor
		{
			get
			{
				return Native.YGConfigGetPointScaleFactor(this._ygConfig);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 282605, RefRangeEnd = 282609, XrefRangeStart = 282603, XrefRangeEnd = 282605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaConfig.NativeMethodInfoPtr_set_PointScaleFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002122 File Offset: 0x00000322
		public YogaConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0001D118 File Offset: 0x0001B318
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000212B File Offset: 0x0000032B
		public unsafe static YogaConfig Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(YogaConfig.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<YogaConfig>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(YogaConfig.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0001D140 File Offset: 0x0001B340
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000213D File Offset: 0x0000033D
		public unsafe IntPtr _ygConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaConfig.NativeFieldInfoPtr__ygConfig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaConfig.NativeFieldInfoPtr__ygConfig)) = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0001D168 File Offset: 0x0001B368
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002158 File Offset: 0x00000358
		public unsafe Logger _logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaConfig.NativeFieldInfoPtr__logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Logger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaConfig.NativeFieldInfoPtr__logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0001D198 File Offset: 0x0001B398
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002177 File Offset: 0x00000377
		public Logger Logger
		{
			get
			{
				return this._logger;
			}
			set
			{
				this._logger = value;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002181 File Offset: 0x00000381
		public void SetExperimentalFeatureEnabled(YogaExperimentalFeature feature, bool enabled)
		{
			Native.YGConfigSetExperimentalFeatureEnabled(this._ygConfig, feature, enabled);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0001D1B0 File Offset: 0x0001B3B0
		public bool IsExperimentalFeatureEnabled(YogaExperimentalFeature feature)
		{
			return Native.YGConfigIsExperimentalFeatureEnabled(this._ygConfig, feature);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		public static int GetInstanceCount()
		{
			return Native.YGConfigGetInstanceCount();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002192 File Offset: 0x00000392
		public static void SetDefaultLogger(Logger logger)
		{
			YogaConfig.Default.Logger = logger;
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr__ygConfig;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr__logger;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_IntPtr_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_UseWebDefaults_Public_get_Boolean_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_set_UseWebDefaults_Public_set_Void_Boolean_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_set_PointScaleFactor_Public_set_Void_Single_0;
	}
}
