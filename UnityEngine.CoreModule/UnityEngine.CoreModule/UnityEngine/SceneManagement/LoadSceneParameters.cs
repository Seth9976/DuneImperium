using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001C3 RID: 451
	[Serializable]
	[StructLayout(2)]
	public struct LoadSceneParameters
	{
		// Token: 0x060020CA RID: 8394 RVA: 0x000914F8 File Offset: 0x0008F6F8
		// Note: this type is marked as 'beforefieldinit'.
		static LoadSceneParameters()
		{
			Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "LoadSceneParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr);
			LoadSceneParameters.NativeFieldInfoPtr_m_LoadSceneMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, "m_LoadSceneMode");
			LoadSceneParameters.NativeFieldInfoPtr_m_LocalPhysicsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, "m_LocalPhysicsMode");
			LoadSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, 100667742);
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00091564 File Offset: 0x0008F764
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 680442, RefRangeEnd = 680452, XrefRangeStart = 680442, XrefRangeEnd = 680442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadSceneParameters(LoadSceneMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x0000C673 File Offset: 0x0000A873
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x00091598 File Offset: 0x0008F798
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x0000C685 File Offset: 0x0000A885
		public LoadSceneMode loadSceneMode
		{
			get
			{
				return this.m_LoadSceneMode;
			}
			set
			{
				this.m_LoadSceneMode = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x000915B0 File Offset: 0x0008F7B0
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x0000C68F File Offset: 0x0000A88F
		public LocalPhysicsMode localPhysicsMode
		{
			get
			{
				return this.m_LocalPhysicsMode;
			}
			set
			{
				this.m_LocalPhysicsMode = value;
			}
		}

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadSceneMode;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalPhysicsMode;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0;

		// Token: 0x04001C27 RID: 7207
		[FieldOffset(0)]
		public LoadSceneMode m_LoadSceneMode;

		// Token: 0x04001C28 RID: 7208
		[FieldOffset(4)]
		public LocalPhysicsMode m_LocalPhysicsMode;
	}
}
