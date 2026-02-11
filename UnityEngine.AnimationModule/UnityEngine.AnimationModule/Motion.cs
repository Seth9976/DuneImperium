using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000023 RID: 35
	public class Motion : Object
	{
		// Token: 0x0600028F RID: 655 RVA: 0x0000FA84 File Offset: 0x0000DC84
		// Note: this type is marked as 'beforefieldinit'.
		static Motion()
		{
			Il2CppClassPointerStore<Motion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "Motion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion>.NativeClassPtr);
			Motion.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion>.NativeClassPtr, 100663728);
			Motion.get_averageDurationDelegateField = IL2CPP.ResolveICall<Motion.get_averageDurationDelegate>("UnityEngine.Motion::get_averageDuration");
			Motion.get_averageAngularSpeedDelegateField = IL2CPP.ResolveICall<Motion.get_averageAngularSpeedDelegate>("UnityEngine.Motion::get_averageAngularSpeed");
			Motion.get_apparentSpeedDelegateField = IL2CPP.ResolveICall<Motion.get_apparentSpeedDelegate>("UnityEngine.Motion::get_apparentSpeed");
			Motion.get_isLoopingDelegateField = IL2CPP.ResolveICall<Motion.get_isLoopingDelegate>("UnityEngine.Motion::get_isLooping");
			Motion.get_legacyDelegateField = IL2CPP.ResolveICall<Motion.get_legacyDelegate>("UnityEngine.Motion::get_legacy");
			Motion.get_isHumanMotionDelegateField = IL2CPP.ResolveICall<Motion.get_isHumanMotionDelegate>("UnityEngine.Motion::get_isHumanMotion");
			Motion.get_averageSpeed_InjectedDelegateField = IL2CPP.ResolveICall<Motion.get_averageSpeed_InjectedDelegate>("UnityEngine.Motion::get_averageSpeed_Injected");
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000FB34 File Offset: 0x0000DD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220836, XrefRangeEnd = 1220840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Motion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Motion.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000283A File Offset: 0x00000A3A
		public Motion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00002843 File Offset: 0x00000A43
		public float averageDuration
		{
			get
			{
				return Motion.get_averageDurationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00002855 File Offset: 0x00000A55
		public float averageAngularSpeed
		{
			get
			{
				return Motion.get_averageAngularSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000FB70 File Offset: 0x0000DD70
		public Vector3 averageSpeed
		{
			get
			{
				Vector3 vector;
				this.get_averageSpeed_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00002867 File Offset: 0x00000A67
		public float apparentSpeed
		{
			get
			{
				return Motion.get_apparentSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00002879 File Offset: 0x00000A79
		public bool isLooping
		{
			get
			{
				return Motion.get_isLoopingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000288B File Offset: 0x00000A8B
		public bool legacy
		{
			get
			{
				return Motion.get_legacyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000289D File Offset: 0x00000A9D
		public bool isHumanMotion
		{
			get
			{
				return Motion.get_isHumanMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000FB88 File Offset: 0x0000DD88
		public bool ValidateIfRetargetable(bool val)
		{
			return false;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000028AF File Offset: 0x00000AAF
		public bool isAnimatorMotion
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000028BC File Offset: 0x00000ABC
		public void get_averageSpeed_Injected(out Vector3 ret)
		{
			Motion.get_averageSpeed_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400029A RID: 666
		private static readonly Motion.get_averageDurationDelegate get_averageDurationDelegateField;

		// Token: 0x0400029B RID: 667
		private static readonly Motion.get_averageAngularSpeedDelegate get_averageAngularSpeedDelegateField;

		// Token: 0x0400029C RID: 668
		private static readonly Motion.get_apparentSpeedDelegate get_apparentSpeedDelegateField;

		// Token: 0x0400029D RID: 669
		private static readonly Motion.get_isLoopingDelegate get_isLoopingDelegateField;

		// Token: 0x0400029E RID: 670
		private static readonly Motion.get_legacyDelegate get_legacyDelegateField;

		// Token: 0x0400029F RID: 671
		private static readonly Motion.get_isHumanMotionDelegate get_isHumanMotionDelegateField;

		// Token: 0x040002A0 RID: 672
		private static readonly Motion.get_averageSpeed_InjectedDelegate get_averageSpeed_InjectedDelegateField;

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x06000601 RID: 1537
		private delegate float get_averageDurationDelegate(IntPtr @this);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000603 RID: 1539
		private delegate float get_averageAngularSpeedDelegate(IntPtr @this);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000605 RID: 1541
		private delegate float get_apparentSpeedDelegate(IntPtr @this);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000607 RID: 1543
		private delegate bool get_isLoopingDelegate(IntPtr @this);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000609 RID: 1545
		private delegate bool get_legacyDelegate(IntPtr @this);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x0600060B RID: 1547
		private delegate bool get_isHumanMotionDelegate(IntPtr @this);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x0600060D RID: 1549
		private delegate void get_averageSpeed_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
