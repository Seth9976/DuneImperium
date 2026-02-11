using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000306 RID: 774
	public sealed class ShaderVariantCollection : Object
	{
		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x000122F2 File Offset: 0x000104F2
		public int shaderCount
		{
			get
			{
				return ShaderVariantCollection.get_shaderCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x00012304 File Offset: 0x00010504
		public int variantCount
		{
			get
			{
				return ShaderVariantCollection.get_variantCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x00012316 File Offset: 0x00010516
		public int warmedUpVariantCount
		{
			get
			{
				return ShaderVariantCollection.get_warmedUpVariantCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002DAB RID: 11691 RVA: 0x00012328 File Offset: 0x00010528
		public bool isWarmedUp
		{
			get
			{
				return ShaderVariantCollection.get_isWarmedUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x0001233A File Offset: 0x0001053A
		public bool AddVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.AddVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00012359 File Offset: 0x00010559
		public bool RemoveVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.RemoveVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00012378 File Offset: 0x00010578
		public bool ContainsVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.ContainsVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00012397 File Offset: 0x00010597
		public void Clear()
		{
			ShaderVariantCollection.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x000123A9 File Offset: 0x000105A9
		public void WarmUp()
		{
			ShaderVariantCollection.WarmUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000123BB File Offset: 0x000105BB
		public bool WarmUpProgressively(int variantCount)
		{
			return ShaderVariantCollection.WarmUpProgressivelyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), variantCount);
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000123CE File Offset: 0x000105CE
		public static void Internal_Create(ShaderVariantCollection svc)
		{
			ShaderVariantCollection.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(svc));
		}

		// Token: 0x04002933 RID: 10547
		private static readonly ShaderVariantCollection.get_shaderCountDelegate get_shaderCountDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_shaderCountDelegate>("UnityEngine.ShaderVariantCollection::get_shaderCount");

		// Token: 0x04002934 RID: 10548
		private static readonly ShaderVariantCollection.get_variantCountDelegate get_variantCountDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_variantCountDelegate>("UnityEngine.ShaderVariantCollection::get_variantCount");

		// Token: 0x04002935 RID: 10549
		private static readonly ShaderVariantCollection.get_warmedUpVariantCountDelegate get_warmedUpVariantCountDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_warmedUpVariantCountDelegate>("UnityEngine.ShaderVariantCollection::get_warmedUpVariantCount");

		// Token: 0x04002936 RID: 10550
		private static readonly ShaderVariantCollection.get_isWarmedUpDelegate get_isWarmedUpDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_isWarmedUpDelegate>("UnityEngine.ShaderVariantCollection::get_isWarmedUp");

		// Token: 0x04002937 RID: 10551
		private static readonly ShaderVariantCollection.AddVariantDelegate AddVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.AddVariantDelegate>("UnityEngine.ShaderVariantCollection::AddVariant");

		// Token: 0x04002938 RID: 10552
		private static readonly ShaderVariantCollection.RemoveVariantDelegate RemoveVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.RemoveVariantDelegate>("UnityEngine.ShaderVariantCollection::RemoveVariant");

		// Token: 0x04002939 RID: 10553
		private static readonly ShaderVariantCollection.ContainsVariantDelegate ContainsVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.ContainsVariantDelegate>("UnityEngine.ShaderVariantCollection::ContainsVariant");

		// Token: 0x0400293A RID: 10554
		private static readonly ShaderVariantCollection.ClearDelegate ClearDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.ClearDelegate>("UnityEngine.ShaderVariantCollection::Clear");

		// Token: 0x0400293B RID: 10555
		private static readonly ShaderVariantCollection.WarmUpDelegate WarmUpDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.WarmUpDelegate>("UnityEngine.ShaderVariantCollection::WarmUp");

		// Token: 0x0400293C RID: 10556
		private static readonly ShaderVariantCollection.WarmUpProgressivelyDelegate WarmUpProgressivelyDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.WarmUpProgressivelyDelegate>("UnityEngine.ShaderVariantCollection::WarmUpProgressively");

		// Token: 0x0400293D RID: 10557
		private static readonly ShaderVariantCollection.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.Internal_CreateDelegate>("UnityEngine.ShaderVariantCollection::Internal_Create");

		// Token: 0x02000B62 RID: 2914
		// (Invoke) Token: 0x06003FB9 RID: 16313
		private delegate int get_shaderCountDelegate(IntPtr @this);

		// Token: 0x02000B63 RID: 2915
		// (Invoke) Token: 0x06003FBB RID: 16315
		private delegate int get_variantCountDelegate(IntPtr @this);

		// Token: 0x02000B64 RID: 2916
		// (Invoke) Token: 0x06003FBD RID: 16317
		private delegate int get_warmedUpVariantCountDelegate(IntPtr @this);

		// Token: 0x02000B65 RID: 2917
		// (Invoke) Token: 0x06003FBF RID: 16319
		private delegate bool get_isWarmedUpDelegate(IntPtr @this);

		// Token: 0x02000B66 RID: 2918
		// (Invoke) Token: 0x06003FC1 RID: 16321
		private delegate bool AddVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000B67 RID: 2919
		// (Invoke) Token: 0x06003FC3 RID: 16323
		private delegate bool RemoveVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000B68 RID: 2920
		// (Invoke) Token: 0x06003FC5 RID: 16325
		private delegate bool ContainsVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000B69 RID: 2921
		// (Invoke) Token: 0x06003FC7 RID: 16327
		private delegate void ClearDelegate(IntPtr @this);

		// Token: 0x02000B6A RID: 2922
		// (Invoke) Token: 0x06003FC9 RID: 16329
		private delegate void WarmUpDelegate(IntPtr @this);

		// Token: 0x02000B6B RID: 2923
		// (Invoke) Token: 0x06003FCB RID: 16331
		private delegate bool WarmUpProgressivelyDelegate(IntPtr @this, int variantCount);

		// Token: 0x02000B6C RID: 2924
		// (Invoke) Token: 0x06003FCD RID: 16333
		private delegate void Internal_CreateDelegate(IntPtr svc);
	}
}
