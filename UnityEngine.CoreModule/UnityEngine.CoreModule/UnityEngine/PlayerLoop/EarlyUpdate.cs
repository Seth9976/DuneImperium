using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001CA RID: 458
	[StructLayout(2)]
	public struct EarlyUpdate
	{
		// Token: 0x060020F4 RID: 8436 RVA: 0x0000C87A File Offset: 0x0000AA7A
		// Note: this type is marked as 'beforefieldinit'.
		static EarlyUpdate()
		{
			Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "EarlyUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x0000C89F File Offset: 0x0000AA9F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x0200089D RID: 2205
		[StructLayout(2)]
		public struct PollPlayerConnection
		{
			// Token: 0x06003A39 RID: 14905 RVA: 0x00014AE0 File Offset: 0x00012CE0
			// Note: this type is marked as 'beforefieldinit'.
			static PollPlayerConnection()
			{
				Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PollPlayerConnection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr);
			}

			// Token: 0x06003A3A RID: 14906 RVA: 0x00014B00 File Offset: 0x00012D00
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200089E RID: 2206
		[StructLayout(2)]
		public struct PollHtcsPlayerConnection
		{
			// Token: 0x06003A3B RID: 14907 RVA: 0x00014B12 File Offset: 0x00012D12
			// Note: this type is marked as 'beforefieldinit'.
			static PollHtcsPlayerConnection()
			{
				Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PollHtcsPlayerConnection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr);
			}

			// Token: 0x06003A3C RID: 14908 RVA: 0x00014B32 File Offset: 0x00012D32
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200089F RID: 2207
		[StructLayout(2)]
		public struct GpuTimestamp
		{
			// Token: 0x06003A3D RID: 14909 RVA: 0x00014B44 File Offset: 0x00012D44
			// Note: this type is marked as 'beforefieldinit'.
			static GpuTimestamp()
			{
				Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "GpuTimestamp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr);
			}

			// Token: 0x06003A3E RID: 14910 RVA: 0x00014B64 File Offset: 0x00012D64
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008A0 RID: 2208
		[StructLayout(2)]
		public struct AnalyticsCoreStatsUpdate
		{
			// Token: 0x06003A3F RID: 14911 RVA: 0x00014B76 File Offset: 0x00012D76
			// Note: this type is marked as 'beforefieldinit'.
			static AnalyticsCoreStatsUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "AnalyticsCoreStatsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A40 RID: 14912 RVA: 0x00014B96 File Offset: 0x00012D96
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008A1 RID: 2209
		[StructLayout(2)]
		public struct UnityWebRequestUpdate
		{
			// Token: 0x06003A41 RID: 14913 RVA: 0x00014BA8 File Offset: 0x00012DA8
			// Note: this type is marked as 'beforefieldinit'.
			static UnityWebRequestUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UnityWebRequestUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A42 RID: 14914 RVA: 0x00014BC8 File Offset: 0x00012DC8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008A2 RID: 2210
		[StructLayout(2)]
		public struct UpdateStreamingManager
		{
			// Token: 0x06003A43 RID: 14915 RVA: 0x00014BDA File Offset: 0x00012DDA
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateStreamingManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateStreamingManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr);
			}

			// Token: 0x06003A44 RID: 14916 RVA: 0x00014BFA File Offset: 0x00012DFA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008A3 RID: 2211
		[StructLayout(2)]
		public struct ExecuteMainThreadJobs
		{
			// Token: 0x06003A45 RID: 14917 RVA: 0x00014C0C File Offset: 0x00012E0C
			// Note: this type is marked as 'beforefieldinit'.
			static ExecuteMainThreadJobs()
			{
				Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ExecuteMainThreadJobs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr);
			}

			// Token: 0x06003A46 RID: 14918 RVA: 0x00014C2C File Offset: 0x00012E2C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008A4 RID: 2212
		[StructLayout(2)]
		public struct ProcessMouseInWindow
		{
			// Token: 0x06003A47 RID: 14919 RVA: 0x00014C3E File Offset: 0x00012E3E
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessMouseInWindow()
			{
				Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProcessMouseInWindow");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr);
			}

			// Token: 0x06003A48 RID: 14920 RVA: 0x00014C5E File Offset: 0x00012E5E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008A5 RID: 2213
		[StructLayout(2)]
		public struct ClearIntermediateRenderers
		{
			// Token: 0x06003A49 RID: 14921 RVA: 0x00014C70 File Offset: 0x00012E70
			// Note: this type is marked as 'beforefieldinit'.
			static ClearIntermediateRenderers()
			{
				Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ClearIntermediateRenderers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr);
			}

			// Token: 0x06003A4A RID: 14922 RVA: 0x00014C90 File Offset: 0x00012E90
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008A6 RID: 2214
		[StructLayout(2)]
		public struct ClearLines
		{
			// Token: 0x06003A4B RID: 14923 RVA: 0x00014CA2 File Offset: 0x00012EA2
			// Note: this type is marked as 'beforefieldinit'.
			static ClearLines()
			{
				Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ClearLines");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr);
			}

			// Token: 0x06003A4C RID: 14924 RVA: 0x00014CC2 File Offset: 0x00012EC2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008A7 RID: 2215
		[StructLayout(2)]
		public struct PresentBeforeUpdate
		{
			// Token: 0x06003A4D RID: 14925 RVA: 0x00014CD4 File Offset: 0x00012ED4
			// Note: this type is marked as 'beforefieldinit'.
			static PresentBeforeUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PresentBeforeUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A4E RID: 14926 RVA: 0x00014CF4 File Offset: 0x00012EF4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008A8 RID: 2216
		[StructLayout(2)]
		public struct ResetFrameStatsAfterPresent
		{
			// Token: 0x06003A4F RID: 14927 RVA: 0x00014D06 File Offset: 0x00012F06
			// Note: this type is marked as 'beforefieldinit'.
			static ResetFrameStatsAfterPresent()
			{
				Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ResetFrameStatsAfterPresent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr);
			}

			// Token: 0x06003A50 RID: 14928 RVA: 0x00014D26 File Offset: 0x00012F26
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008A9 RID: 2217
		[StructLayout(2)]
		public struct UpdateAsyncReadbackManager
		{
			// Token: 0x06003A51 RID: 14929 RVA: 0x00014D38 File Offset: 0x00012F38
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateAsyncReadbackManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateAsyncReadbackManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr);
			}

			// Token: 0x06003A52 RID: 14930 RVA: 0x00014D58 File Offset: 0x00012F58
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008AA RID: 2218
		[StructLayout(2)]
		public struct UpdateTextureStreamingManager
		{
			// Token: 0x06003A53 RID: 14931 RVA: 0x00014D6A File Offset: 0x00012F6A
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateTextureStreamingManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateTextureStreamingManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr);
			}

			// Token: 0x06003A54 RID: 14932 RVA: 0x00014D8A File Offset: 0x00012F8A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008AB RID: 2219
		[StructLayout(2)]
		public struct UpdatePreloading
		{
			// Token: 0x06003A55 RID: 14933 RVA: 0x00014D9C File Offset: 0x00012F9C
			// Note: this type is marked as 'beforefieldinit'.
			static UpdatePreloading()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdatePreloading");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr);
			}

			// Token: 0x06003A56 RID: 14934 RVA: 0x00014DBC File Offset: 0x00012FBC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008AC RID: 2220
		[StructLayout(2)]
		public struct UpdateContentLoading
		{
			// Token: 0x06003A57 RID: 14935 RVA: 0x00014DCE File Offset: 0x00012FCE
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateContentLoading()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateContentLoading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateContentLoading");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateContentLoading>.NativeClassPtr);
			}

			// Token: 0x06003A58 RID: 14936 RVA: 0x00014DEE File Offset: 0x00012FEE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateContentLoading>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008AD RID: 2221
		[StructLayout(2)]
		public struct UpdateAsyncInstantiate
		{
			// Token: 0x06003A59 RID: 14937 RVA: 0x00014E00 File Offset: 0x00013000
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateAsyncInstantiate()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncInstantiate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateAsyncInstantiate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncInstantiate>.NativeClassPtr);
			}

			// Token: 0x06003A5A RID: 14938 RVA: 0x00014E20 File Offset: 0x00013020
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncInstantiate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008AE RID: 2222
		[StructLayout(2)]
		public struct RendererNotifyInvisible
		{
			// Token: 0x06003A5B RID: 14939 RVA: 0x00014E32 File Offset: 0x00013032
			// Note: this type is marked as 'beforefieldinit'.
			static RendererNotifyInvisible()
			{
				Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "RendererNotifyInvisible");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr);
			}

			// Token: 0x06003A5C RID: 14940 RVA: 0x00014E52 File Offset: 0x00013052
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008AF RID: 2223
		[StructLayout(2)]
		public struct PlayerCleanupCachedData
		{
			// Token: 0x06003A5D RID: 14941 RVA: 0x00014E64 File Offset: 0x00013064
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerCleanupCachedData()
			{
				Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PlayerCleanupCachedData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr);
			}

			// Token: 0x06003A5E RID: 14942 RVA: 0x00014E84 File Offset: 0x00013084
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008B0 RID: 2224
		[StructLayout(2)]
		public struct UpdateMainGameViewRect
		{
			// Token: 0x06003A5F RID: 14943 RVA: 0x00014E96 File Offset: 0x00013096
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateMainGameViewRect()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateMainGameViewRect");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr);
			}

			// Token: 0x06003A60 RID: 14944 RVA: 0x00014EB6 File Offset: 0x000130B6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008B1 RID: 2225
		[StructLayout(2)]
		public struct UpdateCanvasRectTransform
		{
			// Token: 0x06003A61 RID: 14945 RVA: 0x00014EC8 File Offset: 0x000130C8
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateCanvasRectTransform()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateCanvasRectTransform");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr);
			}

			// Token: 0x06003A62 RID: 14946 RVA: 0x00014EE8 File Offset: 0x000130E8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008B2 RID: 2226
		[StructLayout(2)]
		public struct UpdateInputManager
		{
			// Token: 0x06003A63 RID: 14947 RVA: 0x00014EFA File Offset: 0x000130FA
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateInputManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateInputManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr);
			}

			// Token: 0x06003A64 RID: 14948 RVA: 0x00014F1A File Offset: 0x0001311A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008B3 RID: 2227
		[StructLayout(2)]
		public struct ProcessRemoteInput
		{
			// Token: 0x06003A65 RID: 14949 RVA: 0x00014F2C File Offset: 0x0001312C
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessRemoteInput()
			{
				Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProcessRemoteInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr);
			}

			// Token: 0x06003A66 RID: 14950 RVA: 0x00014F4C File Offset: 0x0001314C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008B4 RID: 2228
		[StructLayout(2)]
		public struct XRUpdate
		{
			// Token: 0x06003A67 RID: 14951 RVA: 0x00014F5E File Offset: 0x0001315E
			// Note: this type is marked as 'beforefieldinit'.
			static XRUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "XRUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A68 RID: 14952 RVA: 0x00014F7E File Offset: 0x0001317E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008B5 RID: 2229
		[StructLayout(2)]
		public struct ScriptRunDelayedStartupFrame
		{
			// Token: 0x06003A69 RID: 14953 RVA: 0x00014F90 File Offset: 0x00013190
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedStartupFrame()
			{
				Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ScriptRunDelayedStartupFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr);
			}

			// Token: 0x06003A6A RID: 14954 RVA: 0x00014FB0 File Offset: 0x000131B0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008B6 RID: 2230
		[StructLayout(2)]
		public struct UpdateKinect
		{
			// Token: 0x06003A6B RID: 14955 RVA: 0x00014FC2 File Offset: 0x000131C2
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateKinect()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateKinect");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr);
			}

			// Token: 0x06003A6C RID: 14956 RVA: 0x00014FE2 File Offset: 0x000131E2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008B7 RID: 2231
		[StructLayout(2)]
		public struct DeliverIosPlatformEvents
		{
			// Token: 0x06003A6D RID: 14957 RVA: 0x00014FF4 File Offset: 0x000131F4
			// Note: this type is marked as 'beforefieldinit'.
			static DeliverIosPlatformEvents()
			{
				Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "DeliverIosPlatformEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr);
			}

			// Token: 0x06003A6E RID: 14958 RVA: 0x00015014 File Offset: 0x00013214
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008B8 RID: 2232
		[StructLayout(2)]
		public struct DispatchEventQueueEvents
		{
			// Token: 0x06003A6F RID: 14959 RVA: 0x00015026 File Offset: 0x00013226
			// Note: this type is marked as 'beforefieldinit'.
			static DispatchEventQueueEvents()
			{
				Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "DispatchEventQueueEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr);
			}

			// Token: 0x06003A70 RID: 14960 RVA: 0x00015046 File Offset: 0x00013246
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008B9 RID: 2233
		[StructLayout(2)]
		public struct Physics2DEarlyUpdate
		{
			// Token: 0x06003A71 RID: 14961 RVA: 0x00015058 File Offset: 0x00013258
			// Note: this type is marked as 'beforefieldinit'.
			static Physics2DEarlyUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.Physics2DEarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "Physics2DEarlyUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.Physics2DEarlyUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A72 RID: 14962 RVA: 0x00015078 File Offset: 0x00013278
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.Physics2DEarlyUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008BA RID: 2234
		[StructLayout(2)]
		public struct PhysicsResetInterpolatedTransformPosition
		{
			// Token: 0x06003A73 RID: 14963 RVA: 0x0001508A File Offset: 0x0001328A
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsResetInterpolatedTransformPosition()
			{
				Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PhysicsResetInterpolatedTransformPosition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr);
			}

			// Token: 0x06003A74 RID: 14964 RVA: 0x000150AA File Offset: 0x000132AA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008BB RID: 2235
		[StructLayout(2)]
		public struct SpriteAtlasManagerUpdate
		{
			// Token: 0x06003A75 RID: 14965 RVA: 0x000150BC File Offset: 0x000132BC
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteAtlasManagerUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "SpriteAtlasManagerUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A76 RID: 14966 RVA: 0x000150DC File Offset: 0x000132DC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008BC RID: 2236
		[StructLayout(2)]
		public struct TangoUpdate
		{
			// Token: 0x06003A77 RID: 14967 RVA: 0x000150EE File Offset: 0x000132EE
			// Note: this type is marked as 'beforefieldinit'.
			static TangoUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "TangoUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A78 RID: 14968 RVA: 0x0001510E File Offset: 0x0001330E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008BD RID: 2237
		[StructLayout(2)]
		public struct ARCoreUpdate
		{
			// Token: 0x06003A79 RID: 14969 RVA: 0x00015120 File Offset: 0x00013320
			// Note: this type is marked as 'beforefieldinit'.
			static ARCoreUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ARCoreUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A7A RID: 14970 RVA: 0x00015140 File Offset: 0x00013340
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008BE RID: 2238
		[StructLayout(2)]
		public struct PerformanceAnalyticsUpdate
		{
			// Token: 0x06003A7B RID: 14971 RVA: 0x00015152 File Offset: 0x00013352
			// Note: this type is marked as 'beforefieldinit'.
			static PerformanceAnalyticsUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PerformanceAnalyticsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A7C RID: 14972 RVA: 0x00015172 File Offset: 0x00013372
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008BF RID: 2239
		public struct ProfilerStartFrame
		{
		}
	}
}
