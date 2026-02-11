using System;
using DG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x0200004B RID: 75
	public class DOTweenSettings : ScriptableObject
	{
		// Token: 0x06000470 RID: 1136 RVA: 0x0001A748 File Offset: 0x00018948
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenSettings()
		{
			Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "DOTweenSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr);
			DOTweenSettings.NativeFieldInfoPtr_AssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "AssetName");
			DOTweenSettings.NativeFieldInfoPtr_useSafeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "useSafeMode");
			DOTweenSettings.NativeFieldInfoPtr_timeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "timeScale");
			DOTweenSettings.NativeFieldInfoPtr_useSmoothDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "useSmoothDeltaTime");
			DOTweenSettings.NativeFieldInfoPtr_maxSmoothUnscaledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "maxSmoothUnscaledTime");
			DOTweenSettings.NativeFieldInfoPtr_rewindCallbackMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "rewindCallbackMode");
			DOTweenSettings.NativeFieldInfoPtr_showUnityEditorReport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "showUnityEditorReport");
			DOTweenSettings.NativeFieldInfoPtr_logBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "logBehaviour");
			DOTweenSettings.NativeFieldInfoPtr_drawGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "drawGizmos");
			DOTweenSettings.NativeFieldInfoPtr_defaultRecyclable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultRecyclable");
			DOTweenSettings.NativeFieldInfoPtr_defaultAutoPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultAutoPlay");
			DOTweenSettings.NativeFieldInfoPtr_defaultUpdateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultUpdateType");
			DOTweenSettings.NativeFieldInfoPtr_defaultTimeScaleIndependent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultTimeScaleIndependent");
			DOTweenSettings.NativeFieldInfoPtr_defaultEaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultEaseType");
			DOTweenSettings.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultEaseOvershootOrAmplitude");
			DOTweenSettings.NativeFieldInfoPtr_defaultEasePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultEasePeriod");
			DOTweenSettings.NativeFieldInfoPtr_defaultAutoKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultAutoKill");
			DOTweenSettings.NativeFieldInfoPtr_defaultLoopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultLoopType");
			DOTweenSettings.NativeFieldInfoPtr_storeSettingsLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "storeSettingsLocation");
			DOTweenSettings.NativeFieldInfoPtr_showPlayingTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "showPlayingTweens");
			DOTweenSettings.NativeFieldInfoPtr_showPausedTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "showPausedTweens");
			DOTweenSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, 100664226);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001A930 File Offset: 0x00018B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133580, XrefRangeEnd = 1133581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DOTweenSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00003654 File Offset: 0x00001854
		public DOTweenSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0001A96C File Offset: 0x00018B6C
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x0000365D File Offset: 0x0000185D
		public unsafe static string AssetName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DOTweenSettings.NativeFieldInfoPtr_AssetName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTweenSettings.NativeFieldInfoPtr_AssetName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0001A98C File Offset: 0x00018B8C
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x0000366F File Offset: 0x0000186F
		public unsafe bool useSafeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_useSafeMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_useSafeMode)) = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0001A9B4 File Offset: 0x00018BB4
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x0000368A File Offset: 0x0000188A
		public unsafe float timeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_timeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_timeScale)) = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0001A9DC File Offset: 0x00018BDC
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x000036A5 File Offset: 0x000018A5
		public unsafe bool useSmoothDeltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_useSmoothDeltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_useSmoothDeltaTime)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0001AA04 File Offset: 0x00018C04
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x000036C0 File Offset: 0x000018C0
		public unsafe float maxSmoothUnscaledTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_maxSmoothUnscaledTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_maxSmoothUnscaledTime)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0001AA2C File Offset: 0x00018C2C
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x000036DB File Offset: 0x000018DB
		public unsafe RewindCallbackMode rewindCallbackMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_rewindCallbackMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_rewindCallbackMode)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0001AA54 File Offset: 0x00018C54
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x000036F6 File Offset: 0x000018F6
		public unsafe bool showUnityEditorReport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showUnityEditorReport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showUnityEditorReport)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0001AA7C File Offset: 0x00018C7C
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00003711 File Offset: 0x00001911
		public unsafe LogBehaviour logBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_logBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_logBehaviour)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x0001AAA4 File Offset: 0x00018CA4
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x0000372C File Offset: 0x0000192C
		public unsafe bool drawGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_drawGizmos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_drawGizmos)) = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0001AACC File Offset: 0x00018CCC
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00003747 File Offset: 0x00001947
		public unsafe bool defaultRecyclable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultRecyclable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultRecyclable)) = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0001AAF4 File Offset: 0x00018CF4
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00003762 File Offset: 0x00001962
		public unsafe AutoPlay defaultAutoPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultAutoPlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultAutoPlay)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0001AB1C File Offset: 0x00018D1C
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x0000377D File Offset: 0x0000197D
		public unsafe UpdateType defaultUpdateType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultUpdateType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultUpdateType)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0001AB44 File Offset: 0x00018D44
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00003798 File Offset: 0x00001998
		public unsafe bool defaultTimeScaleIndependent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultTimeScaleIndependent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultTimeScaleIndependent)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0001AB6C File Offset: 0x00018D6C
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x000037B3 File Offset: 0x000019B3
		public unsafe Ease defaultEaseType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEaseType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEaseType)) = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0001AB94 File Offset: 0x00018D94
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x000037CE File Offset: 0x000019CE
		public unsafe float defaultEaseOvershootOrAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude)) = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0001ABBC File Offset: 0x00018DBC
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x000037E9 File Offset: 0x000019E9
		public unsafe float defaultEasePeriod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEasePeriod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEasePeriod)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0001ABE4 File Offset: 0x00018DE4
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00003804 File Offset: 0x00001A04
		public unsafe bool defaultAutoKill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultAutoKill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultAutoKill)) = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0001AC0C File Offset: 0x00018E0C
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x0000381F File Offset: 0x00001A1F
		public unsafe LoopType defaultLoopType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultLoopType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultLoopType)) = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0001AC34 File Offset: 0x00018E34
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x0000383A File Offset: 0x00001A3A
		public unsafe DOTweenSettings.SettingsLocation storeSettingsLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_storeSettingsLocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_storeSettingsLocation)) = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0001AC5C File Offset: 0x00018E5C
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00003855 File Offset: 0x00001A55
		public unsafe bool showPlayingTweens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showPlayingTweens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showPlayingTweens)) = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0001AC84 File Offset: 0x00018E84
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00003870 File Offset: 0x00001A70
		public unsafe bool showPausedTweens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showPausedTweens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showPausedTweens)) = value;
			}
		}

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_AssetName;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_useSafeMode;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_timeScale;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_useSmoothDeltaTime;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_maxSmoothUnscaledTime;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_rewindCallbackMode;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_showUnityEditorReport;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_logBehaviour;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_drawGizmos;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_defaultRecyclable;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_defaultAutoPlay;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_defaultUpdateType;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeFieldInfoPtr_defaultTimeScaleIndependent;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr_defaultEaseType;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_defaultEasePeriod;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeFieldInfoPtr_defaultAutoKill;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeFieldInfoPtr_defaultLoopType;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_storeSettingsLocation;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_showPlayingTweens;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_showPausedTweens;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000EC RID: 236
		public enum SettingsLocation
		{
			// Token: 0x04000642 RID: 1602
			AssetsDirectory,
			// Token: 0x04000643 RID: 1603
			DOTweenDirectory,
			// Token: 0x04000644 RID: 1604
			DemigiantDirectory
		}
	}
}
