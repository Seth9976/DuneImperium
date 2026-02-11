using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SubsystemsImplementation
{
	// Token: 0x0200000F RID: 15
	public class SubsystemWithProvider : Object
	{
		// Token: 0x06000085 RID: 133 RVA: 0x000024A0 File Offset: 0x000006A0
		// Note: this type is marked as 'beforefieldinit'.
		static SubsystemWithProvider()
		{
			Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine.SubsystemsImplementation", "SubsystemWithProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr);
			SubsystemWithProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr, 100663330);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003860 File Offset: 0x00001A60
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubsystemWithProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemWithProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000024D9 File Offset: 0x000006D9
		public SubsystemWithProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000024E2 File Offset: 0x000006E2
		public void Start()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000024EF File Offset: 0x000006EF
		public void Stop()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000389C File Offset: 0x00001A9C
		public void Destroy()
		{
			this.Stop();
			bool flag = SubsystemManager.RemoveStandaloneSubsystem(this);
			if (flag)
			{
				this.OnDestroy();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000024FC File Offset: 0x000006FC
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002509 File Offset: 0x00000709
		public bool running
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002516 File Offset: 0x00000716
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002523 File Offset: 0x00000723
		public SubsystemProvider providerBase
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
