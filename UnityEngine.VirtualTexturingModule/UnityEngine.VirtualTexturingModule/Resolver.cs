using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000005 RID: 5
	public class Resolver
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000246C File Offset: 0x0000066C
		public ~Resolver()
		{
			this.Dispose(false);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021E2 File Offset: 0x000003E2
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000021F4 File Offset: 0x000003F4
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002201 File Offset: 0x00000401
		public static IntPtr InitNative()
		{
			return Resolver.InitNativeDelegateField();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000220D File Offset: 0x0000040D
		public static void ReleaseNative(IntPtr ptr)
		{
			Resolver.ReleaseNativeDelegateField(ptr);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000221A File Offset: 0x0000041A
		public void Flush_Internal()
		{
			Resolver.Flush_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000222C File Offset: 0x0000042C
		public void Init_Internal(int width, int height)
		{
			Resolver.Init_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), width, height);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002240 File Offset: 0x00000440
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000224D File Offset: 0x0000044D
		public int CurrentWidth
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000225A File Offset: 0x0000045A
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002267 File Offset: 0x00000467
		public int CurrentHeight
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

		// Token: 0x06000023 RID: 35 RVA: 0x000024A0 File Offset: 0x000006A0
		public void UpdateSize(int width, int height)
		{
			bool flag = this.CurrentWidth != width || this.CurrentHeight != height;
			if (flag)
			{
				bool flag2 = width <= 0 || height <= 0;
				if (flag2)
				{
					throw new ArgumentException(String.Format("Zero sized dimensions are invalid (width: {0}, height: {1}.", width, height));
				}
				this.CurrentWidth = width;
				this.CurrentHeight = height;
				this.Flush_Internal();
				this.Init_Internal(this.CurrentWidth, this.CurrentHeight);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002528 File Offset: 0x00000728
		public void Process(CommandBuffer cmd, RenderTargetIdentifier rt)
		{
			this.Process(cmd, rt, 0, this.CurrentWidth, 0, this.CurrentHeight, 0, 0);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002274 File Offset: 0x00000474
		public void Process(CommandBuffer cmd, RenderTargetIdentifier rt, int x, int width, int y, int height, int mip, int slice)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000012 RID: 18
		private static readonly Resolver.InitNativeDelegate InitNativeDelegateField = IL2CPP.ResolveICall<Resolver.InitNativeDelegate>("UnityEngine.Rendering.VirtualTexturing.Resolver::InitNative");

		// Token: 0x04000013 RID: 19
		private static readonly Resolver.ReleaseNativeDelegate ReleaseNativeDelegateField = IL2CPP.ResolveICall<Resolver.ReleaseNativeDelegate>("UnityEngine.Rendering.VirtualTexturing.Resolver::ReleaseNative");

		// Token: 0x04000014 RID: 20
		private static readonly Resolver.Flush_InternalDelegate Flush_InternalDelegateField = IL2CPP.ResolveICall<Resolver.Flush_InternalDelegate>("UnityEngine.Rendering.VirtualTexturing.Resolver::Flush_Internal");

		// Token: 0x04000015 RID: 21
		private static readonly Resolver.Init_InternalDelegate Init_InternalDelegateField = IL2CPP.ResolveICall<Resolver.Init_InternalDelegate>("UnityEngine.Rendering.VirtualTexturing.Resolver::Init_Internal");

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000055 RID: 85
		private delegate IntPtr InitNativeDelegate();

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000057 RID: 87
		private delegate void ReleaseNativeDelegate(IntPtr ptr);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000059 RID: 89
		private delegate void Flush_InternalDelegate(IntPtr @this);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x0600005B RID: 91
		private delegate void Init_InternalDelegate(IntPtr @this, int width, int height);
	}
}
