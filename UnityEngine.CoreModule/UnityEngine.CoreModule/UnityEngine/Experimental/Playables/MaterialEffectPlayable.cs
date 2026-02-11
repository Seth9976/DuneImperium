using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x0200027B RID: 635
	[StructLayout(2)]
	public struct MaterialEffectPlayable
	{
		// Token: 0x06002B4C RID: 11084 RVA: 0x000AF80C File Offset: 0x000ADA0C
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialEffectPlayable()
		{
			Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "MaterialEffectPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr);
			MaterialEffectPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, "m_Handle");
			MaterialEffectPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100668624);
			MaterialEffectPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100668625);
			MaterialEffectPlayable.GetMaterialInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.GetMaterialInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetMaterialInternal");
			MaterialEffectPlayable.SetMaterialInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.SetMaterialInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetMaterialInternal");
			MaterialEffectPlayable.GetPassInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.GetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetPassInternal");
			MaterialEffectPlayable.SetPassInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.SetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetPassInternal");
			MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::InternalCreateMaterialEffectPlayable");
			MaterialEffectPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::ValidateType");
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x000AF8D4 File Offset: 0x000ADAD4
		[CallerCount(0)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEffectPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000AF904 File Offset: 0x000ADB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686193, XrefRangeEnd = 686200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(MaterialEffectPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEffectPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x00010E83 File Offset: 0x0000F083
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x000AF944 File Offset: 0x000ADB44
		public static MaterialEffectPlayable Create(UnityEngine.Playables.PlayableGraph graph, Material material, [Optional] int pass)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = MaterialEffectPlayable.CreateHandle(graph, material, pass);
			return new MaterialEffectPlayable(playableHandle);
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x000AF968 File Offset: 0x000ADB68
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, Material material, int pass)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !MaterialEffectPlayable.InternalCreateMaterialEffectPlayable(ref graph, material, pass, ref @null);
			UnityEngine.Playables.PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x000AF99C File Offset: 0x000ADB9C
		public static implicit operator UnityEngine.Playables.Playable(MaterialEffectPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x000AF9BC File Offset: 0x000ADBBC
		public static explicit operator MaterialEffectPlayable(UnityEngine.Playables.Playable playable)
		{
			return new MaterialEffectPlayable(playable.GetHandle());
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x000AF9DC File Offset: 0x000ADBDC
		public Material GetMaterial()
		{
			return MaterialEffectPlayable.GetMaterialInternal(ref this.m_Handle);
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x00010E95 File Offset: 0x0000F095
		public void SetMaterial(Material value)
		{
			MaterialEffectPlayable.SetMaterialInternal(ref this.m_Handle, value);
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x000AF9FC File Offset: 0x000ADBFC
		public int GetPass()
		{
			return MaterialEffectPlayable.GetPassInternal(ref this.m_Handle);
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x00010EA5 File Offset: 0x0000F0A5
		public void SetPass(int value)
		{
			MaterialEffectPlayable.SetPassInternal(ref this.m_Handle, value);
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000AFA1C File Offset: 0x000ADC1C
		public static Material GetMaterialInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			IntPtr intPtr = MaterialEffectPlayable.GetMaterialInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x00010EB5 File Offset: 0x0000F0B5
		public static void SetMaterialInternal(ref UnityEngine.Playables.PlayableHandle hdl, Material material)
		{
			MaterialEffectPlayable.SetMaterialInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(material));
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00010EC8 File Offset: 0x0000F0C8
		public static int GetPassInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return MaterialEffectPlayable.GetPassInternalDelegateField(ref hdl);
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00010ED5 File Offset: 0x0000F0D5
		public static void SetPassInternal(ref UnityEngine.Playables.PlayableHandle hdl, int pass)
		{
			MaterialEffectPlayable.SetPassInternalDelegateField(ref hdl, pass);
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x00010EE3 File Offset: 0x0000F0E3
		public static bool InternalCreateMaterialEffectPlayable(ref UnityEngine.Playables.PlayableGraph graph, Material material, int pass, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(material), pass, ref handle);
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00010EF8 File Offset: 0x0000F0F8
		public static bool ValidateType(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return MaterialEffectPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x04002662 RID: 9826
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04002663 RID: 9827
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04002664 RID: 9828
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0;

		// Token: 0x04002665 RID: 9829
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x04002666 RID: 9830
		private static readonly MaterialEffectPlayable.GetMaterialInternalDelegate GetMaterialInternalDelegateField;

		// Token: 0x04002667 RID: 9831
		private static readonly MaterialEffectPlayable.SetMaterialInternalDelegate SetMaterialInternalDelegateField;

		// Token: 0x04002668 RID: 9832
		private static readonly MaterialEffectPlayable.GetPassInternalDelegate GetPassInternalDelegateField;

		// Token: 0x04002669 RID: 9833
		private static readonly MaterialEffectPlayable.SetPassInternalDelegate SetPassInternalDelegateField;

		// Token: 0x0400266A RID: 9834
		private static readonly MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegate InternalCreateMaterialEffectPlayableDelegateField;

		// Token: 0x0400266B RID: 9835
		private static readonly MaterialEffectPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x02000A66 RID: 2662
		// (Invoke) Token: 0x06003DF0 RID: 15856
		private delegate IntPtr GetMaterialInternalDelegate(IntPtr hdl);

		// Token: 0x02000A67 RID: 2663
		// (Invoke) Token: 0x06003DF2 RID: 15858
		private delegate void SetMaterialInternalDelegate(IntPtr hdl, IntPtr material);

		// Token: 0x02000A68 RID: 2664
		// (Invoke) Token: 0x06003DF4 RID: 15860
		private delegate int GetPassInternalDelegate(IntPtr hdl);

		// Token: 0x02000A69 RID: 2665
		// (Invoke) Token: 0x06003DF6 RID: 15862
		private delegate void SetPassInternalDelegate(IntPtr hdl, int pass);

		// Token: 0x02000A6A RID: 2666
		// (Invoke) Token: 0x06003DF8 RID: 15864
		private delegate bool InternalCreateMaterialEffectPlayableDelegate(IntPtr graph, IntPtr material, int pass, IntPtr handle);

		// Token: 0x02000A6B RID: 2667
		// (Invoke) Token: 0x06003DFA RID: 15866
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}
