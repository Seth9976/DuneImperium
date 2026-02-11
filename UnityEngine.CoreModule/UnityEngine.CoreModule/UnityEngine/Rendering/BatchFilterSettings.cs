using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000221 RID: 545
	[StructLayout(2)]
	public struct BatchFilterSettings
	{
		// Token: 0x06002498 RID: 9368 RVA: 0x0009D634 File Offset: 0x0009B834
		// Note: this type is marked as 'beforefieldinit'.
		static BatchFilterSettings()
		{
			Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchFilterSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr);
			BatchFilterSettings.NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "renderingLayerMask");
			BatchFilterSettings.NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "layer");
			BatchFilterSettings.NativeFieldInfoPtr_m_motionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_motionMode");
			BatchFilterSettings.NativeFieldInfoPtr_m_shadowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_shadowMode");
			BatchFilterSettings.NativeFieldInfoPtr_m_receiveShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_receiveShadows");
			BatchFilterSettings.NativeFieldInfoPtr_m_staticShadowCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_staticShadowCaster");
			BatchFilterSettings.NativeFieldInfoPtr_m_allDepthSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_allDepthSorted");
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x0000E595 File Offset: 0x0000C795
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x0000E5A7 File Offset: 0x0000C7A7
		// (set) Token: 0x0600249B RID: 9371 RVA: 0x0000E5AF File Offset: 0x0000C7AF
		public MotionVectorGenerationMode motionMode
		{
			get
			{
				return (MotionVectorGenerationMode)this.m_motionMode;
			}
			set
			{
				this.m_motionMode = (byte)value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x0000E5B9 File Offset: 0x0000C7B9
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x0000E5C1 File Offset: 0x0000C7C1
		public ShadowCastingMode shadowCastingMode
		{
			get
			{
				return (ShadowCastingMode)this.m_shadowMode;
			}
			set
			{
				this.m_shadowMode = (byte)value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x0000E5CB File Offset: 0x0000C7CB
		// (set) Token: 0x0600249F RID: 9375 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
		public bool receiveShadows
		{
			get
			{
				return this.m_receiveShadows > 0;
			}
			set
			{
				this.m_receiveShadows = (value ? 1 : 0);
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0000E5E6 File Offset: 0x0000C7E6
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x0000E5F1 File Offset: 0x0000C7F1
		public bool staticShadowCaster
		{
			get
			{
				return this.m_staticShadowCaster > 0;
			}
			set
			{
				this.m_staticShadowCaster = (value ? 1 : 0);
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x0000E601 File Offset: 0x0000C801
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x0000E60C File Offset: 0x0000C80C
		public bool allDepthSorted
		{
			get
			{
				return this.m_allDepthSorted > 0;
			}
			set
			{
				this.m_allDepthSorted = (value ? 1 : 0);
			}
		}

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMask;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeFieldInfoPtr_layer;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeFieldInfoPtr_m_motionMode;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeFieldInfoPtr_m_shadowMode;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeFieldInfoPtr_m_receiveShadows;

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeFieldInfoPtr_m_staticShadowCaster;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeFieldInfoPtr_m_allDepthSorted;

		// Token: 0x0400202E RID: 8238
		[FieldOffset(0)]
		public uint renderingLayerMask;

		// Token: 0x0400202F RID: 8239
		[FieldOffset(4)]
		public byte layer;

		// Token: 0x04002030 RID: 8240
		[FieldOffset(5)]
		public byte m_motionMode;

		// Token: 0x04002031 RID: 8241
		[FieldOffset(6)]
		public byte m_shadowMode;

		// Token: 0x04002032 RID: 8242
		[FieldOffset(7)]
		public byte m_receiveShadows;

		// Token: 0x04002033 RID: 8243
		[FieldOffset(8)]
		public byte m_staticShadowCaster;

		// Token: 0x04002034 RID: 8244
		[FieldOffset(9)]
		public byte m_allDepthSorted;
	}
}
