using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000090 RID: 144
	[StructLayout(2)]
	public struct RenderBuffer
	{
		// Token: 0x06000833 RID: 2099 RVA: 0x00030CC4 File Offset: 0x0002EEC4
		// Note: this type is marked as 'beforefieldinit'.
		static RenderBuffer()
		{
			Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr);
			RenderBuffer.NativeFieldInfoPtr_m_RenderTextureInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, "m_RenderTextureInstanceID");
			RenderBuffer.NativeFieldInfoPtr_m_BufferPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, "m_BufferPtr");
			RenderBuffer.SetLoadAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.SetLoadAction_InjectedDelegate>("UnityEngine.RenderBuffer::SetLoadAction_Injected");
			RenderBuffer.SetStoreAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.SetStoreAction_InjectedDelegate>("UnityEngine.RenderBuffer::SetStoreAction_Injected");
			RenderBuffer.GetLoadAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetLoadAction_InjectedDelegate>("UnityEngine.RenderBuffer::GetLoadAction_Injected");
			RenderBuffer.GetStoreAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetStoreAction_InjectedDelegate>("UnityEngine.RenderBuffer::GetStoreAction_Injected");
			RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegate>("UnityEngine.RenderBuffer::GetNativeRenderBufferPtr_Injected");
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00005169 File Offset: 0x00003369
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, ref this));
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0000517B File Offset: 0x0000337B
		public void SetLoadAction(UnityEngine.Rendering.RenderBufferLoadAction action)
		{
			RenderBuffer.SetLoadAction_Injected(ref this, action);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00005184 File Offset: 0x00003384
		public void SetStoreAction(UnityEngine.Rendering.RenderBufferStoreAction action)
		{
			RenderBuffer.SetStoreAction_Injected(ref this, action);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0000518D File Offset: 0x0000338D
		public UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction()
		{
			return RenderBuffer.GetLoadAction_Injected(ref this);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00005195 File Offset: 0x00003395
		public UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction()
		{
			return RenderBuffer.GetStoreAction_Injected(ref this);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0000519D File Offset: 0x0000339D
		public IntPtr GetNativeRenderBufferPtr()
		{
			return RenderBuffer.GetNativeRenderBufferPtr_Injected(ref this);
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00030D68 File Offset: 0x0002EF68
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x000051A5 File Offset: 0x000033A5
		public UnityEngine.Rendering.RenderBufferLoadAction loadAction
		{
			get
			{
				return this.GetLoadAction();
			}
			set
			{
				this.SetLoadAction(value);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00030D80 File Offset: 0x0002EF80
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x000051B0 File Offset: 0x000033B0
		public UnityEngine.Rendering.RenderBufferStoreAction storeAction
		{
			get
			{
				return this.GetStoreAction();
			}
			set
			{
				this.SetStoreAction(value);
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000051BB File Offset: 0x000033BB
		public static void SetLoadAction_Injected(ref RenderBuffer _unity_self, UnityEngine.Rendering.RenderBufferLoadAction action)
		{
			RenderBuffer.SetLoadAction_InjectedDelegateField(ref _unity_self, action);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000051C9 File Offset: 0x000033C9
		public static void SetStoreAction_Injected(ref RenderBuffer _unity_self, UnityEngine.Rendering.RenderBufferStoreAction action)
		{
			RenderBuffer.SetStoreAction_InjectedDelegateField(ref _unity_self, action);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000051D7 File Offset: 0x000033D7
		public static UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction_Injected(ref RenderBuffer _unity_self)
		{
			return RenderBuffer.GetLoadAction_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000051E4 File Offset: 0x000033E4
		public static UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction_Injected(ref RenderBuffer _unity_self)
		{
			return RenderBuffer.GetStoreAction_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000051F1 File Offset: 0x000033F1
		public static IntPtr GetNativeRenderBufferPtr_Injected(ref RenderBuffer _unity_self)
		{
			return RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderTextureInstanceID;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferPtr;

		// Token: 0x040006A4 RID: 1700
		[FieldOffset(0)]
		public int m_RenderTextureInstanceID;

		// Token: 0x040006A5 RID: 1701
		[FieldOffset(8)]
		public IntPtr m_BufferPtr;

		// Token: 0x040006A6 RID: 1702
		private static readonly RenderBuffer.SetLoadAction_InjectedDelegate SetLoadAction_InjectedDelegateField;

		// Token: 0x040006A7 RID: 1703
		private static readonly RenderBuffer.SetStoreAction_InjectedDelegate SetStoreAction_InjectedDelegateField;

		// Token: 0x040006A8 RID: 1704
		private static readonly RenderBuffer.GetLoadAction_InjectedDelegate GetLoadAction_InjectedDelegateField;

		// Token: 0x040006A9 RID: 1705
		private static readonly RenderBuffer.GetStoreAction_InjectedDelegate GetStoreAction_InjectedDelegateField;

		// Token: 0x040006AA RID: 1706
		private static readonly RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegate GetNativeRenderBufferPtr_InjectedDelegateField;

		// Token: 0x020004CE RID: 1230
		// (Invoke) Token: 0x060032AD RID: 12973
		private delegate void SetLoadAction_InjectedDelegate(IntPtr _unity_self, UnityEngine.Rendering.RenderBufferLoadAction action);

		// Token: 0x020004CF RID: 1231
		// (Invoke) Token: 0x060032AF RID: 12975
		private delegate void SetStoreAction_InjectedDelegate(IntPtr _unity_self, UnityEngine.Rendering.RenderBufferStoreAction action);

		// Token: 0x020004D0 RID: 1232
		// (Invoke) Token: 0x060032B1 RID: 12977
		private delegate UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020004D1 RID: 1233
		// (Invoke) Token: 0x060032B3 RID: 12979
		private delegate UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020004D2 RID: 1234
		// (Invoke) Token: 0x060032B5 RID: 12981
		private delegate IntPtr GetNativeRenderBufferPtr_InjectedDelegate(IntPtr _unity_self);
	}
}
