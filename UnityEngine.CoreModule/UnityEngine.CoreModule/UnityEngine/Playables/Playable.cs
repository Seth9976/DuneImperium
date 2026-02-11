using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000260 RID: 608
	[StructLayout(2)]
	public struct Playable
	{
		// Token: 0x0600298B RID: 10635 RVA: 0x000AC214 File Offset: 0x000AA414
		// Note: this type is marked as 'beforefieldinit'.
		static Playable()
		{
			Il2CppClassPointerStore<Playable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "Playable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Playable>.NativeClassPtr);
			Playable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Playable>.NativeClassPtr, "m_Handle");
			Playable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Playable>.NativeClassPtr, "m_NullPlayable");
			Playable.NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100668534);
			Playable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100668535);
			Playable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100668536);
			Playable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100668537);
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x000AC2BC File Offset: 0x000AA4BC
		public unsafe static Playable Null
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685722, XrefRangeEnd = 685726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x000AC2EC File Offset: 0x000AA4EC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 557179, RefRangeEnd = 557192, XrefRangeStart = 557179, XrefRangeEnd = 557192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000AC320 File Offset: 0x000AA520
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x000AC350 File Offset: 0x000AA550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685726, XrefRangeEnd = 685736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Playable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000101D0 File Offset: 0x0000E3D0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Playable>.NativeClassPtr, ref this));
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x000AC390 File Offset: 0x000AA590
		// (set) Token: 0x06002992 RID: 10642 RVA: 0x000101E2 File Offset: 0x0000E3E2
		public unsafe static Playable m_NullPlayable
		{
			get
			{
				Playable playable;
				IL2CPP.il2cpp_field_static_get_value(Playable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&playable));
				return playable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Playable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000AC3AC File Offset: 0x000AA5AC
		public static Playable Create(PlayableGraph graph, [Optional] int inputCount)
		{
			Playable playable = new Playable(graph.CreatePlayableHandle());
			PlayableExtensions.SetInputCount<Playable>(playable, inputCount);
			return playable;
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000AC3D8 File Offset: 0x000AA5D8
		public bool IsPlayableOfType<T>() where T : struct
		{
			return this.GetHandle().IsPlayableOfType<T>();
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000AC3F8 File Offset: 0x000AA5F8
		public Type GetPlayableType()
		{
			return this.GetHandle().GetPlayableType();
		}

		// Token: 0x040024CD RID: 9421
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040024CE RID: 9422
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x040024CF RID: 9423
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0;

		// Token: 0x040024D0 RID: 9424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0;

		// Token: 0x040024D3 RID: 9427
		[FieldOffset(0)]
		public PlayableHandle m_Handle;
	}
}
